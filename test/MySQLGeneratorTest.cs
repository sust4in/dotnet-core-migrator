using Xunit;
using Ozziest.Generators;
using Ozziest.Columns;

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
        
    }
}
