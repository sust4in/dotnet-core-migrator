using Ozziest.Columns;
using Ozziest.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace test.MySQL.Columns
{
    public class IntTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestInt()
        {
            IColumn column = new Int("user_id");
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`user_id` INT NOT NULL AUTO_INCREMENT", generator.Int(column));
        }

    }
}
