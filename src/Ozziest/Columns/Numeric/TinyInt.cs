namespace Ozziest.Columns.Numeric
{
    public class TinyInt : ColumnDecorator
    {
        public TinyInt(string name, int length)
        {
            _name = name;
            _length = length;
            _type = "TINYINT";
        }
    }
}
