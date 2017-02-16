using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class BigIntTest
    {

        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestInt()
        {
            IColumn column = new BigIntColumn("foo", 20);
            column.NotNull();
            column.AutoIncrement();
            Assert.Equal("`foo` BIGINT(20) NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }

    }
}
