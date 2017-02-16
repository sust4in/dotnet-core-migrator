using System;

namespace Ozziest.Columns.String
{
    public class BlobColumn : ColumnDecorator
    {
        public BlobColumn(string name)
        {
            _name = name;
            _type = "BLOB";
        }
    }
}