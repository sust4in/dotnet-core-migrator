using System;

namespace Ozziest.Columns.DateTime
{

    public class Date : ColumnDecorator
    {

        public Date(string name)
        {
            _name = name;
            _type = "DATE";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("DATE field can not be set as auto increment field.");
        }

    }

}
