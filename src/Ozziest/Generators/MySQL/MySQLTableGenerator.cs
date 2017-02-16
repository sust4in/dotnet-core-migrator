using Ozziest.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Generators.MySQL
{

    public class MySQLTableGenerator: ITableGenerator
    {

        public string Create(string table, List<IColumn> columns)
        {
            IFieldGenerator generator = new MySQLFieldGenerator();
            string sql = "CREATE TABLE `{0}` ({1})";
            string columnSQL = "";
            foreach (IColumn column in columns)
            {
                columnSQL += " " + generator.ToSQL(column) + ",";
            }
            columnSQL = columnSQL.Substring(0, columnSQL.Length - 1).Trim();
            return string.Format(sql, table, columnSQL);
        }

    }

}
