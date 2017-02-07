namespace Ozziest.Columns.Numeric
{

    public class IntColumn : ColumnDecorator 
    {

        public IntColumn(string name)
        {
            _name = name;
            _type = "INT";
        }

    }

}