using System.Collections.Generic;
using Ozziest.Columns;

namespace Ozziest.Generators 
{

    public interface IGenerator 
    {

        string Create(string table, List<IColumn> column);

        string ToSQL(IColumn column);

        string VarChar(IColumn column);

    }

}