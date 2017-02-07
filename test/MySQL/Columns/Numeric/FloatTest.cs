using System;
using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class FloatTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestFloat()
        {
            IColumn column = new FloatColumn("my_float_field", 7, 4);
            column.NotNull();
            Assert.Equal("`my_float_field` FLOAT(7, 4) NOT NULL", generator.ToSQL(column));
        }

    }
}
