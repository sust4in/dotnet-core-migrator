namespace Ozziest.Columns 
{

    public interface IColumn 
    {

        IColumn SetUnique();

        IColumn SetNotNull();

        IColumn SetNull();

        string Name();

        string Type();

        int Length();

        bool IsNullable();

        bool IsUnique();

    }

}