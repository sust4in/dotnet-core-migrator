using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class TinyIntTest
    {
        private MySQLGenerator generator = new MySQLGenerator();

        [Fact]
        public void TestTinyInt()
        {
            IColumn column = new TinyIntColumn("line_no");
            column.SetNotNull();
            column.SetAutoIncrement();
            Assert.Equal("`line_no` TINYINT NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }
    }
}
