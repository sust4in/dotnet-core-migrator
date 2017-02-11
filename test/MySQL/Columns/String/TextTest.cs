using System;
using Ozziest.Columns;
using Ozziest.Columns.String;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.String
{
    public class TextTest
    {
        
        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestText()
        {
        //Given
        IColumn column = new TextColumn("description");
        Assert.Equal("`description` TEXT", generator.ToSQL(column));

        //When
        
        //Then
        }

        [Fact]
        public void TestTextCharExceptionAutoIncrement()
        {
            IColumn column = new TextColumn("description");
            Assert.Throws<Exception>(() => column.AutoIncrement());
        }
    }
}