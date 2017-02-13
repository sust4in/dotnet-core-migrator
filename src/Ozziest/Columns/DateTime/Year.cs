using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ozziest.Columns.DateTime
{
    public class Year : ColumnDecorator
    {
        public Year(string name)
        {
            _name = name;
            _type = "YEAR";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("YEAR field cannot be set as auto increment field.");
        }
    }
}
