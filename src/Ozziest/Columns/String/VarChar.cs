using System;

namespace Ozziest.Columns.String
{

    public class VarChar : ColumnDecorator 
    {

        public VarChar(string name, int length)
        {
            _name = name;
            _length = length;
            _type = "VARCHAR";
        }

        public override IColumn SetAutoIncrement()
        {
            throw new Exception("VarChar field can not be set as auto increment field.");
        }

    }

}