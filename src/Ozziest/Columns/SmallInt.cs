using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Columns
{
    public class SmallInt:ColumnDecorator
    {
        public SmallInt(string name,int length)
        {
            _name = name;
            _length = length;
            _type = "SMALLINT";
        }
    }
}
