using System;

namespace Ozziest.Columns.Numeric
{

    public class DoubleColumn : ColumnDecorator 
    {

        public DoubleColumn(string name, int length, int decimalLength)
        {
            _name = name;
            _length = length;
            _decimal = decimalLength; 
            _type = "DOUBLE";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("Double field can not be set as an auto increment field.");
        }        

    }

}