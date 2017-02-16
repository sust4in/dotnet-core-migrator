using System;
using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;
using Ozziest.Generators.MySQL;

namespace test.MySQL.Columns.Numeric
{
    public class DecimalTest
    {

        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestDecimal()
        {
            IColumn column = new DecimalColumn("my_decimal_field", 5, 2);
            column.NotNull();
            Assert.Equal("`my_decimal_field` DECIMAL(5, 2) NOT NULL", generator.ToSQL(column));
        }

        [Fact]
        public void TestExceptionAutoIncrement()
        {
            IColumn column = new DecimalColumn("my_decimal_field", 5, 2);
            Assert.Throws<Exception>(() => column.AutoIncrement());
        }

    }
}
