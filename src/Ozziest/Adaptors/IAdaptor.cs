using System.Collections.Generic;

namespace Ozziest.Adaptors
{
    public interface IAdaptor
    {

        long Create (string sql);

        void Execute(string sql);

        List<dynamic> Get(string sql);

    }
    
}