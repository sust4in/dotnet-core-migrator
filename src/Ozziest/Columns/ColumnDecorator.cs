namespace Ozziest.Columns
{

    public class ColumnDecorator: IColumn
    {

        protected string _name;
        protected string _type;
        protected int _length;

        protected int _precision;
        protected int _scale;

        protected bool isPrimaryKey = false;

        protected bool isAutoIncrement = false;

        protected bool isUnique = false;
        protected bool isNullable = true;

        public virtual IColumn Unique()
        {
            isUnique = true;
            return this;
        }

        public virtual IColumn NotNull()
        {
            isNullable = false;
            return this;
        }

        public virtual IColumn Nullable()
        {
            isNullable = true;
            return this;
        }

        public virtual IColumn PrimaryKey()
        {
            isPrimaryKey = true;
            return this;
        }

        public virtual IColumn AutoIncrement()
        {
            isAutoIncrement = true;
            return this;
        }        

        public virtual string Name()
        {
            return _name;
        }

        public virtual string Type()
        {
            return _type;
        }

        public virtual int Length()
        {
            return _length;
        }

        public virtual int Precision()
        {
            return _precision;
        }
        public virtual int Scale()
        {
            return _scale;
        }

        public virtual bool IsNullable()
        {
            return isNullable;
        }

        public virtual bool IsUnique()
        {
            return isUnique;
        }

        public virtual bool IsPrimaryKey()
        {
            return isPrimaryKey;
        }

        public virtual bool IsAutoIncrement()
        {
            return isAutoIncrement;
        }
        
        
    }

}