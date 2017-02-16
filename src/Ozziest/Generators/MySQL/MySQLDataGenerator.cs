using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Generators.MySQL
{
    public class MySQLDataGenerator: IDataGenerator
    {

        public string Insert(string table, Dictionary<string, dynamic> items)
        {
            return "";
        }

        public string Update(string table, string key, dynamic value, Dictionary<string, dynamic> items)
        {
            return "";
        }

        public string Delete(string table, string key, dynamic value)
        {
            return "";
        }

    }
}
