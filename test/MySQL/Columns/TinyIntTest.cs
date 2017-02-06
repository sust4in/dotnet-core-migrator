using Ozziest.Columns;
using Ozziest.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace test.MySQL.Columns
{
    public class TinyIntTest
    {
        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestTinyInt()
        {
            IColumn column = new Int("line_no");
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`line_no` TINYINT NOT NULL AUTO_INCREMENT", generator.TinyInt(column));
        }
    }
}
