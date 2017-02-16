using Ozziest.Columns;
using Ozziest.Columns.Numeric;
using Ozziest.Generators;
using Ozziest.Generators.MySQL;
using Xunit;

namespace test.MySQL.Columns.Numeric
{
    public class TinyIntTest
    {
        private IFieldGenerator generator = new MySQLFieldGenerator();

        [Fact]
        public void TestTinyInt()
        {
            IColumn column = new TinyIntColumn("line_no");
            column.NotNull();
            column.AutoIncrement();
            Assert.Equal("`line_no` TINYINT NOT NULL AUTO_INCREMENT", generator.ToSQL(column));
        }
    }
}
