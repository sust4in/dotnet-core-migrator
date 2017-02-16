using Ozziest.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Generators
{

    public interface IFieldGenerator
    {

        string ToSQL(IColumn column);

    }

}
