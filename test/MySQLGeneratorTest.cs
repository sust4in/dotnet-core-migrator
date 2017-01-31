using Xunit;
using Ozziest.Generators;
using Ozziest.Columns;
using System;

namespace Ozziest.UnitTests
{
    public class MySQLGeneratorTest
    {

        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestVarChar()
        {
            // Simple varchar
            IColumn column = new VarChar("users", 100);
            Assert.Equal("`users` VARCHAR(100)", generator.VarChar(column));

            // Advanced var char
            column = new VarChar("nickname", 50);
            column.SetNotNull();
            column.SetUnique();
            Assert.Equal("`nickname` VARCHAR(50) NOT NULL UNIQUE", generator.VarChar(column));
        }

        [Fact]
        public void TestInt()
        {
            // Simple varchar
            IColumn column = new Int("user_id");
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`user_id` INT NOT NULL AUTO_INCREMENT", generator.Int(column));
        }

        [Fact]
        public void TestBit()
        {
            // Simple varchar
            IColumn column = new Bit("is_online");
            Assert.Equal("`is_online` BIT(1)", generator.Bit(column));
        }

        [Fact]
        public void TestBitExceptionAutoIncrement()
        {
            // Simple varchar
            IColumn column = new Bit("is_online");
            Assert.Throws<Exception>(() => column.SetAutoIncrement());
        }

        [Fact]
        public void TestBitExceptionUnique()
        {
            // Simple varchar
            IColumn column = new Bit("is_online");
            Assert.Throws<Exception>(() => column.SetUnique());
        }

        [Fact]
        public void TestBitExceptionPrimaryKey()
        {
            // Simple varchar
            IColumn column = new Bit("is_online");
            Assert.Throws<Exception>(() => column.SetPrimaryKey());
        }

    }
}
