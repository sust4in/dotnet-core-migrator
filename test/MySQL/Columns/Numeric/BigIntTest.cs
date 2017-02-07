using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class BigIntTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestInt()
        {
            IColumn column = new BigIntColumn("foo", 20);
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`foo` BIGINT(20) NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }

    }
}
