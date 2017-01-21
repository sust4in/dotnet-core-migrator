namespace Ozziest.Columns 
{

    public class VarChar : ColumnDecorator 
    {

        public VarChar(string name, int length)
        {
            _name = name;
            _length = length;
            _type = "VARCHAR";
        }

    }

}