using System;

namespace Ozziest.Columns.Numeric
{

    public class FloatColumn : ColumnDecorator 
    {

        public FloatColumn(string name, int length, int decimalLength)
        {
            _name = name;
            _length = length;
            _decimal = decimalLength; 
            _type = "FLOAT";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("Float field can not be set as an auto increment field.");
        }        

    }

}