using System;

namespace Ozziest.Columns.DateTime
{
    public class Time : ColumnDecorator
    {

        public Time(string name, int? length)
        {
            if (length != null && length > 6)
            {
                throw new Exception("TIME field optional value must be in range 0 to 6.");
            }

            _name = name;
            _length = length == null ? -1 : (int)length;
            _type = "TIME";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("TIME field cannot be set as auto increment field.");
        }

    }
}
