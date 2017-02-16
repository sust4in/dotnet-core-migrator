using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class IntTest
    {

        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestInt()
        {
            IColumn column = new IntColumn("user_id");
            column.NotNull();
            column.AutoIncrement();
            Assert.Equal("`user_id` INT NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }

    }
}
