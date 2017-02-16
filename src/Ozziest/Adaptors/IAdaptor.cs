using System.Collections.Generic;
using Ozziest.Generators;

namespace Ozziest.Adaptors
{
    public interface IAdaptor
    {

        long Create (string sql);

        void Execute(string sql);

        List<dynamic> Get(string sql);

        ITableGenerator TableGenerator();

        IFieldGenerator FieldGenerator();

    }

}