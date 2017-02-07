namespace Ozziest.Columns.Numeric
{
    public class SmallIntColumn:ColumnDecorator
    {
        public SmallIntColumn(string name,int length)
        {
            _name = name;
            _length = length;
            _type = "SMALLINT";
        }
    }
}
