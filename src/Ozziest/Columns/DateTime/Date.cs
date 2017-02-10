using System;

namespace Ozziest.Columns.DateTime
{

    public class Date : ColumnDecorator
    {

        public Date(string name, int? length)
        {
            if (length != null && length > 6)
            {
                throw new Exception("DATE field optional value must be in range 0 to 6.");
            }

            _name = name;
            _length = length == null ? -1 : (int)length;
            _type = "DATE";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("DATE field cannot be set as auto increment field.");
        }

        public override IColumn PrimaryKey()
        {
            throw new Exception("DATE field cannot be set as primary key.");
        }

    }

}
