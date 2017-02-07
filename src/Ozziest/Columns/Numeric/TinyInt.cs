namespace Ozziest.Columns.Numeric
{
    public class TinyInt : ColumnDecorator
    {
        public TinyInt(string name)
        {
            _name = name;
            _type = "TINYINT";
        }
    }
}
