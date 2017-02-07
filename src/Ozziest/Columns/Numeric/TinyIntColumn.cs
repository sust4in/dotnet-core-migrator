namespace Ozziest.Columns.Numeric
{
    public class TinyIntColumn : ColumnDecorator
    {
        public TinyIntColumn(string name)
        {
            _name = name;
            _type = "TINYINT";
        }
    }
}
