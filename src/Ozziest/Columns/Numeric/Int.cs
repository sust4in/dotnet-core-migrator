namespace Ozziest.Columns.Numeric
{

    public class Int : ColumnDecorator 
    {

        public Int(string name)
        {
            _name = name;
            _type = "INT";
        }

    }

}