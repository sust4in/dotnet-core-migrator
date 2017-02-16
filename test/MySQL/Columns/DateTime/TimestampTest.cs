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
    public class TimestampTest
    {
        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestDate()
        {
            IColumn column = new Timestamp("created_atStamp", 6);
            column.Unique();
            column.NotNull();
            Assert.Equal("`created_atStamp` TIMESTAMP(6) NOT NULL UNIQUE", generator.ToSQL(column));
        }
    }
}
