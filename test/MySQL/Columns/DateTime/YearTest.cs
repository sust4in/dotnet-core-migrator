using Ozziest.Columns;
using Ozziest.Columns.DateTime;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace test.MySQL.Columns.DateTime
{
    public class YearTest
    {
        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestDate()
        {
            IColumn column = new Year("created_year");
            column.NotNull();
            Assert.Equal("`created_year` YEAR NOT NULL", generator.ToSQL(column));
        }
    }
}
