using System;
using Ozziest.Columns;
using Ozziest.Columns.String;
using Ozziest.Generators;
using Xunit;
using Ozziest.Generators.MySQL;

namespace test.MySQL.Columns.String
{
    public class TextTest
    {

        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestText()
        {
            IColumn column = new TextColumn("description");
            Assert.Equal("`description` TEXT", generator.ToSQL(column));
        }

        [Fact]
        public void TestTextCharExceptionAutoIncrement()
        {
            IColumn column = new TextColumn("description");
            Assert.Throws<Exception>(() => column.AutoIncrement());
        }

    }
}