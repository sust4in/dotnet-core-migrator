using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
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
