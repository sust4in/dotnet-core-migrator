namespace Ozziest.Columns 
{

    public interface IColumn 
    {

        IColumn SetUnique();

        IColumn SetPrimaryKey();

        IColumn SetAutoIncrement();

        IColumn SetNotNull();

        IColumn SetNull();

        string Name();

        string Type();

        int Length();

        int Precision();
        
        int Scale();

        bool IsNullable();

        bool IsUnique();

        bool IsPrimaryKey();

        bool IsAutoIncrement();

    }

}