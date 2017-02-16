using System.Collections.Generic;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;

namespace Ozziest.Adaptors
{
    public class MySQLAdaptor: IAdaptor
    {

        private string _connectionString;
        private ITableGenerator _tableGenerator = new MySQLTableGenerator();
        private IFieldGenerator _fieldGenerator = new MySQLFieldGenerator();

        public MySQLAdaptor(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public long Create (string sql)
        {
            return -1;
        }

        public void Execute(string sql)
        {
            
        }

        public List<dynamic> Get(string sql)
        {
            return new List<dynamic>();
        }

        public ITableGenerator TableGenerator()
        {
            return _tableGenerator;
        }

        public IFieldGenerator FieldGenerator()
        {
            return _fieldGenerator;
        }

    }

}