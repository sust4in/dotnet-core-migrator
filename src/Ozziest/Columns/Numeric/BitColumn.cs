using System;

namespace Ozziest.Columns.Numeric
{

    public class BitColumn : ColumnDecorator 
    {

        public BitColumn(string name)
        {
            _name = name;
            _length = 1;
            _type = "BIT";
        }

        public override IColumn Unique()
        {
            throw new Exception("Bit field can not be set as unique.");
        }

        public override IColumn PrimaryKey()
        {
            throw new Exception("Bit field can not be set as primary key.");
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("Bit field can not be set as an auto increment field.");
        }

    }

}