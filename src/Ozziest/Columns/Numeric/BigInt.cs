namespace Ozziest.Columns.Numeric
{

    public class BigInt : ColumnDecorator 
    {

        public BigInt(string name, int length)
        {
            _name = name;
            _length = length;
            _type = "BIGINT";
        }

    }

}