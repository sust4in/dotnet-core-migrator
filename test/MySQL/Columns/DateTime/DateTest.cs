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
    public class DateTest
    {
        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestDate()
        {
            IColumn column = new Date("created_at", 4);
            column.Unique();
            column.NotNull();
            Assert.Equal("`created_at` DATE(4) NOT NULL UNIQUE", generator.ToSQL(column));
        }
    }
}
