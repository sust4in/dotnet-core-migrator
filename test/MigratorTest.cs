using System;
using Ozziest;
using Ozziest.Adaptors;
using Ozziest.Columns;
using Xunit;

namespace Ozziest.UnitTests
{
    public class MigratorTest
    {
        private Migrator migrator = new Migrator(new MySQLAdaptor("my_connection_string"));

        [Fact]
        public void TestSettingAdaptor()
        {
            Assert.IsType<MySQLAdaptor>(migrator.Adaptor());
            migrator.Table("users");
        }

        [Fact]
        public void TestTableData()
        {
            migrator.Table("users");
            Assert.Equal(migrator.GetTable(), "users");
        }

        [Fact]
        public void TestColumnAdd()
        {
            IColumn column = migrator.AddColumn(new VarChar("email", 100))
                .SetUnique()
                .SetNotNull();
                
            Assert.Equal(column.Name(), "email");
            Assert.Equal(column.Length(), 100);
            Assert.Equal(column.IsUnique(), true);
            Assert.Equal(column.IsNullable(), false);
            Assert.Equal(migrator.ColumnCount(), 1);

            column = migrator.GetColumnByName("email");
            Assert.Equal(column.IsNullable(), false);
        }
        
    }
}
