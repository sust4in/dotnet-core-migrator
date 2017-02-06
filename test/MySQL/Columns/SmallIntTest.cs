using Ozziest.Columns;
using Ozziest.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace test.MySQL.Columns
{
    public class SmallIntTest
    {
        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestSmallInt()
        {
            IColumn column = new Int("shoe_size");
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`shoe_size` SMALLINT NOT NULL AUTO_INCREMENT", generator.SmallInt(column));
        }
    }
}
