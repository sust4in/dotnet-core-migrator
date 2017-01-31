using Ozziest.Columns;
using System;
using System.Collections.Generic;

namespace Ozziest.Generators 
{

    public class MySQLGenerator: IGenerator 
    {

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

    }

}