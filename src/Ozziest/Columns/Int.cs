using System;

namespace Ozziest.Columns 
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