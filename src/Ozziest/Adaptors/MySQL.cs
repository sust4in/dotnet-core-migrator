using System.Collections.Generic;
using Ozziest.Generators;

namespace Ozziest.Adaptors
{
    public class MySQLAdaptor: IAdaptor
    {

        private string _connectionString;
        private IGenerator _generator = new MySQLGenerator();

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

        public IGenerator Generator()
        {
            return _generator;
        }

    }
    
}