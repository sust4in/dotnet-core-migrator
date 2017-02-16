using Ozziest.Columns;
using Ozziest.Columns.String;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;
using System;
using Xunit;

namespace test.MySQL.Columns.String
{
    public class VarCharTest
    {

        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestVarChar()
        {
            // Simple varchar
            IColumn column = new VarCharColumn("users", 100);
            Assert.Equal("`users` VARCHAR(100)", generator.ToSQL(column));

            // Advanced var char
            column = new VarCharColumn("nickname", 50);
            column.NotNull();
            column.Unique();
            Assert.Equal("`nickname` VARCHAR(50) NOT NULL UNIQUE", generator.ToSQL(column));
        }

        [Fact]
        public void TestVarCharExceptionAutoIncrement()
        {
            IColumn column = new VarCharColumn("users", 100);
            Assert.Throws<Exception>(() => column.AutoIncrement());
        }

    }
}
