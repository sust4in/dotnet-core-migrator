using System.Collections.Generic;
using Ozziest.Adaptors;
using Ozziest.Generators;

namespace Ozziest.UnitTests.Mocks
{

    public class MockAdaptor: IAdaptor
    {

        private string _connectionString;
        private string lastSQL;

        private IGenerator _generator = new MySQLGenerator();

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

        public IGenerator Generator()
        {
            return _generator;
        }

    }

}