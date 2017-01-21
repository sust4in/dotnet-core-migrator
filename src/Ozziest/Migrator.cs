using System.Collections.Generic;
using Ozziest.Adaptors;
using Ozziest.Columns;

namespace Ozziest
{
    public class Migrator
    {

        private IAdaptor adaptor;
        private string _table;

        private List<IColumn> columns = new List<IColumn>();

        public Migrator (IAdaptor _adaptor)
        {
            adaptor = _adaptor;
        }

        public IAdaptor Adaptor()
        {
            return adaptor;
        }

        public Migrator Table(string name)
        {
            _table = name;
            return this;
        }

        public string GetTable()
        {
            return _table;
        }

        public IColumn AddColumn(IColumn column)
        {
            columns.Add(column);
            return column;
        }

        public int ColumnCount()
        {
            return columns.Count;
        }

        public IColumn GetColumnByName(string name)
        {
            return columns.Find(i => i.Name() == name);
        }

        public void Create()
        {
            string sql = adaptor.Generator().Create(_table, columns);
            adaptor.Create(sql);
        }

    }
}