using Ozziest.Columns;
using Ozziest.Columns.DateTime;
using Ozziest.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace test.MySQL.Columns.DateTime
{
    public class DateTest
    {
        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestDate()
        {
            IColumn column = new Date("created_at");
            column.NotNull();
            column.Unique();
            Assert.Equal("`created_at` DATE NOT NULL UNIQUE", generator.ToSQL(column));
        }
    }
}
