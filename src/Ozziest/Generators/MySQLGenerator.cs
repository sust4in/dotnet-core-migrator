using Ozziest.Columns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ozziest.Generators
{

    public class MySQLGenerator : IGenerator
    {

        StringBuilder sb = null;

        public string Create(string table, List<IColumn> columns)
        {
            string sql = "CREATE TABLE `{0}` ({1})";
            string columnSQL = "";
            foreach (IColumn column in columns)
            {
                columnSQL += " " + ToSQL(column) + ",";
            }
            columnSQL = columnSQL.Substring(0, columnSQL.Length - 1).Trim();
            return string.Format(sql, table, columnSQL);
        }

        public string ToSQL(IColumn column)
        {
            switch (column.Type())
            {
                case "VARCHAR":
                    return VarChar(column);
                case "INT":
                    return Int(column);
                case "BIT":
                    return Bit(column);
                case "BIGINT":
                    return BigInt(column);
                case "TINYINT":
                    return TinyInt(column);
                case "SMALLINT":
                    return SmallInt(column);
                case "DECIMAL":
                    return Decimal(column);
                case "FLOAT":
                    return Float(column);
                case "DOUBLE":
                    return Double(column);
                case "DATE":
                    return Date(column);
                default:
                    throw new Exception("Column type not found: " + column.Type());
            }
        }

        public string Int(IColumn column)
        {
            string sql = "`{0}` INT";
            sql = string.Format(sql, column.Name(), column.Length());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            if (column.IsUnique())
            {
                sql += " UNIQUE";
            }

            if (column.IsAutoIncrement())
            {
                sql += " AUTO_INCREMENT";
            }

            return sql;
        }

        public string BigInt(IColumn column)
        {
            string sql = "`{0}` BIGINT({1})";
            sql = string.Format(sql, column.Name(), column.Length());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            if (column.IsUnique())
            {
                sql += " UNIQUE";
            }

            if (column.IsAutoIncrement())
            {
                sql += " AUTO_INCREMENT";
            }

            return sql;
        }

        public string Bit(IColumn column)
        {
            string sql = "`{0}` BIT(1)";
            sql = string.Format(sql, column.Name(), column.Length());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            return sql;
        }

        public string VarChar(IColumn column)
        {
            string sql = "`{0}` VARCHAR({1})";
            sql = string.Format(sql, column.Name(), column.Length());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            if (column.IsUnique())
            {
                sql += " UNIQUE";
            }

            return sql;
        }

        public string TinyInt(IColumn column)
        {
            sb = new StringBuilder();
            sb.AppendFormat("`{0}` TINYINT", column.Name());

            if (column.IsNullable() == false)
            {
                sb.Append(" NOT NULL");
            }

            if (column.IsUnique())
            {
                sb.Append(" UNIQUE");
            }

            if (column.IsAutoIncrement())
            {
                sb.Append(" AUTO_INCREMENT");
            }

            return sb.ToString();
        }

        public string SmallInt(IColumn column)
        {
            sb = new StringBuilder();
            sb.AppendFormat("`{0}` SMALLINT({1})", column.Name(), column.Length());

            if (column.IsNullable() == false)
            {
                sb.Append(" NOT NULL");
            }

            if (column.IsUnique())
            {
                sb.Append(" UNIQUE");
            }

            if (column.IsAutoIncrement())
            {
                sb.Append(" AUTO_INCREMENT");
            }

            return sb.ToString();
        }

        public string Decimal(IColumn column)
        {
            string sql = "`{0}` DECIMAL({1}, {2})";
            sql = string.Format(sql, column.Name(), column.Precision(), column.Scale());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            if (column.IsUnique())
            {
                sql += " UNIQUE";
            }

            if (column.IsAutoIncrement())
            {
                sql += " AUTO_INCREMENT";
            }

            return sql;
        }

        public string Float(IColumn column)
        {
            string sql = "`{0}` FLOAT({1}, {2})";
            sql = string.Format(sql, column.Name(), column.Length(), column.Decimal());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            if (column.IsUnique())
            {
                sql += " UNIQUE";
            }

            return sql;
        }

        public string Double(IColumn column)
        {
            string sql = "`{0}` DOUBLE({1}, {2})";
            sql = string.Format(sql, column.Name(), column.Length(), column.Decimal());

            if (column.IsNullable() == false)
            {
                sql += " NOT NULL";
            }

            if (column.IsUnique())
            {
                sql += " UNIQUE";
            }

            return sql;
        }

        public string Date(IColumn column)
        {
            sb = new StringBuilder();
            sb.AppendFormat("`{0}` DATE", column.Name());

            if (column.IsNullable() == false)
            {
                sb.Append(" NOT NULL");
            }

            if (column.IsUnique())
            {
                sb.Append(" UNIQUE");
            }

            return sb.ToString();
        }

    }

}