namespace Ozziest.Columns.Numeric
{
    public class SmallInt:ColumnDecorator
    {
        public SmallInt(string name,int length)
        {
            _name = name;
            _length = length;
            _type = "SMALLINT";
        }
    }
}
