using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class SmallIntTest
    {
        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestSmallInt()
        {
            IColumn column = new SmallIntColumn("shoe_size", 2);
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`shoe_size` SMALLINT(2) NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }
    }
}
