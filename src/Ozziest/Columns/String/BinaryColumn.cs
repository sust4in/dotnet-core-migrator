using System;

namespace Ozziest.Columns.String
{
    public class BinaryColumn : ColumnDecorator
    {
        public BinaryColumn(string name)
        {
            _name = name;
            _type = "BINARY";
        }
    }
}