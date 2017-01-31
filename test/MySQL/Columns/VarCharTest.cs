using Ozziest.Columns;
using Ozziest.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace test.MySQL.Columns
{
    public class VarCharTest
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
        public void TestVarCharExceptionAutoIncrement()
        {
            IColumn column = new VarChar("users", 100);
            Assert.Throws<Exception>(() => column.SetAutoIncrement());
        }

    }
}
