using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class SmallIntTest
    {
        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestSmallInt()
        {
            IColumn column = new SmallIntColumn("shoe_size", 2);
            column.NotNull();
            column.AutoIncrement();
            Assert.Equal("`shoe_size` SMALLINT(2) NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }
    }
}
