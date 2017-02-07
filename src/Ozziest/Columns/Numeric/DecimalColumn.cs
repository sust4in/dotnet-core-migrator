using System;

namespace Ozziest.Columns.Numeric
{

    public class DecimalColumn : ColumnDecorator 
    {

        public DecimalColumn(string name, int precision, int scale)
        {
            _name = name;
            _precision = precision;
            _scale = scale; 
            _type = "DECIMAL";
        }

        public override IColumn SetAutoIncrement()
        {
            throw new Exception("Decimal field can not be set as an auto increment field.");
        }        

    }

}