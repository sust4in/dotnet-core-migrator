namespace Ozziest.Columns 
{

    public interface IColumn 
    {

        IColumn Unique();

        IColumn PrimaryKey();

        IColumn AutoIncrement();

        IColumn NotNull();

        IColumn Nullable();

        string Name();

        string Type();

        int Length();

        int Precision();
        
        int Scale();

        int Decimal();

        bool IsNullable();

        bool IsUnique();

        bool IsPrimaryKey();

        bool IsAutoIncrement();

    }

}