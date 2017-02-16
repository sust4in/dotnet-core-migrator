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
    public class TimeTest
    {
        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestDate()
        {
            IColumn column = new Time("times", 2);
            column.Unique();
            column.NotNull();
            Assert.Equal("`times` TIME(2) NOT NULL UNIQUE", generator.ToSQL(column));
        }
    }
}
