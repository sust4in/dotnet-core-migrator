namespace Ozziest.Columns.Numeric
{

    public class BigIntColumn : ColumnDecorator 
    {

        public BigIntColumn(string name, int length)
        {
            _name = name;
            _length = length;
            _type = "BIGINT";
        }

    }

}