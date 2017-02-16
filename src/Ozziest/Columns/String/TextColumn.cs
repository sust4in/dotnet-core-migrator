using System;

namespace Ozziest.Columns.String
{
    public class TextColumn : ColumnDecorator
    {
        public TextColumn(string name)
        {
            _name = name;
            _type = "TEXT";
        }

        public override IColumn AutoIncrement()
        {
            throw new Exception("Text field can not be set as auto increment field.");
        }

    }
}