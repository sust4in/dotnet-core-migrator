using System;
using Ozziest.Adaptors;

namespace Ozziest
{
    public class DatabaseAdaptor
    {

        public const string MYSQL = "MYSQL";

        public static IAdaptor Get(string type, string connectionString)
        {
            switch (type)
            {
                case "MYSQL":
                    return new MySQL(connectionString);
                    break;
                default:
                    throw new Exception("Adaptor type not supported: " + type);
                    break;
            }
        }

    }
}