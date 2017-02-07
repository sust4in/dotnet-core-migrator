using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using System;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class BitTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestBit()
        {
            IColumn column = new BitColumn("is_online");
            Assert.Equal("`is_online` BIT(1)", generator.ToSQL(column));
        }

        [Fact]
        public void TestBitExceptionAutoIncrement()
        {
            IColumn column = new BitColumn("is_online");
            Assert.Throws<Exception>(() => column.AutoIncrement());
        }

        [Fact]
        public void TestBitExceptionUnique()
        {
            IColumn column = new BitColumn("is_online");
            Assert.Throws<Exception>(() => column.Unique());
        }

        [Fact]
        public void TestBitExceptionPrimaryKey()
        {
            IColumn column = new BitColumn("is_online");
            Assert.Throws<Exception>(() => column.PrimaryKey());
        }

    }
}
