using System;

namespace Ozziest.Columns.Numeric
{

    public class Bit : ColumnDecorator 
    {

        public Bit(string name)
        {
            _name = name;
            _length = 1;
            _type = "BIT";
        }

        public override IColumn SetUnique()
        {
            throw new Exception("Bit field can not be set as unique.");
        }

        public override IColumn SetPrimaryKey()
        {
            throw new Exception("Bit field can not be set as primary key.");
        }

        public override IColumn SetAutoIncrement()
        {
            throw new Exception("Bit field can not be set as an auto increment field.");
        }

    }

}