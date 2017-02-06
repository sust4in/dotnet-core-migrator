using System.Collections.Generic;
using Ozziest.Columns;

namespace Ozziest.Generators 
{

    public interface IGenerator 
    {

        string Create(string table, List<IColumn> column);

        string ToSQL(IColumn column);

        string Int(IColumn column);

        string Bit(IColumn column);

        string VarChar(IColumn column);

        string TinyInt(IColumn column);

    }

}