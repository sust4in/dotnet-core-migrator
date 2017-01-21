namespace Ozziest.Adaptors
{
    public class MySQL: IAdaptor
    {

        private string _connectionString;

        public MySQL(string connectionString)
        {
            this._connectionString = connectionString;
        }


    }
    
}