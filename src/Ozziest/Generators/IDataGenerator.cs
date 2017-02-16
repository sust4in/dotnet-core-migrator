using Ozziest.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Generators
{

    public interface IDataGenerator
    {

        string Insert(string table, Dictionary<string, dynamic> items);

        string Update(string table, string key, dynamic value, Dictionary<string, dynamic> items);

        string Delete(string table, string key, dynamic value);

    }

}
