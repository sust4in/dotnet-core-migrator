using System;
using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class DoubleTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestDouble()
        {
            IColumn column = new DoubleColumn("my_double_field", 7, 4);
            column.NotNull();
            Assert.Equal("`my_double_field` DOUBLE(7, 4) NOT NULL", generator.ToSQL(column));
        }

        [Fact]
        public void TestExceptionAutoIncrement()
        {
            IColumn column = new DoubleColumn("my_double_field", 7, 4);
            Assert.Throws<Exception>(() => column.AutoIncrement());
        }        

    }
}
