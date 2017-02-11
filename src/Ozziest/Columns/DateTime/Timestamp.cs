using System;

namespace Ozziest.Columns.DateTime
{
    public class Timestamp : ColumnDecorator
    {
        public Timestamp(string name, int? length)
        {
            if (length != null && length > 6)
            {
                throw new Exception("TIMESTAMP field optional value must be in range 0 to 6.");
            }

            _name = name;
            _length = length == null ? -1 : (int)length;
            _type = "TIMESTAMP";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("DATE field cannot be set as auto increment field.");
        }
    }
}
