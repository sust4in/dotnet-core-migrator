using System.Collections.Generic;
using Ozziest.Adaptors;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;

namespace Ozziest.UnitTests.Mocks
{

    public class MockAdaptor: IAdaptor
    {

        private string _connectionString;
        private string lastSQL;

        private ITableGenerator _tableGenerator = new MySQLTableGenerator();
        private IFieldGenerator _fieldGenerator = new MySQLFieldGenerator();

        public MockAdaptor(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public long Create (string sql)
        {
            lastSQL = sql;
            return 1;
        }

        public void Execute(string sql)
        {
        }

        public List<dynamic> Get(string sql)
        {
            return new List<dynamic>();
        }

        public string GetLastSQL()
        {
            return lastSQL;
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