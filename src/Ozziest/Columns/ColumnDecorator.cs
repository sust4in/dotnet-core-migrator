namespace Ozziest.Columns
{

    public class ColumnDecorator: IColumn
    {

        protected string _name;
        protected string _type;
        protected int _length;

        protected bool isUnique = false;
        protected bool isNullable = true;

        public virtual IColumn SetUnique()
        {
            isUnique = true;
            return this;
        }

        public virtual IColumn SetNotNull()
        {
            isNullable = false;
            return this;
        }

        public virtual IColumn SetNull()
        {
            isNullable = true;
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

        public virtual bool IsNullable()
        {
            return isNullable;
        }

        public virtual bool IsUnique()
        {
            return isUnique;
        }
        
    }

}