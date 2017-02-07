using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class DecimalTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestDecimal()
        {
            IColumn column = new DecimalTest("my_decimal_field", 5, 2);
            column.SetNotNull();
            Assert.Equal("`my_decimal_field` DECIMAL(5, 2) NOT NULL", generator.ToSQL(column));
        }

    }
}
