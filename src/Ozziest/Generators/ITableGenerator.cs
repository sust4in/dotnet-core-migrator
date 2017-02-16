using Ozziest.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Generators
{

    public interface ITableGenerator
    {

        string Create(string table, List<IColumn> columns);

    }

}
