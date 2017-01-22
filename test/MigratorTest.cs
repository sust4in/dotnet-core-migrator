using System;
using Ozziest.Columns;
using Ozziest.UnitTests.Mocks;
using Xunit;

namespace Ozziest.UnitTests
{
    public class MigratorTest
    {
        private MockAdaptor adaptor = new MockAdaptor("my_connection_string");
        private Migrator migrator;

        public MigratorTest() 
        {
            migrator = new Migrator(adaptor);
        }

        [Fact]
        public void TestSettingAdaptor()
        {
            Assert.IsType<MockAdaptor>(migrator.Adaptor());
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
            migrator.Table("users");
 
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

            migrator.Create();
            Assert.Equal(
                    "CREATE TABLE `users` (`email` VARCHAR(100) NOT NULL UNIQUE)", 
                    adaptor.GetLastSQL()
                );
        }

        [Fact]
        public void TestAutoIncrementException()
        {
            IColumn column = migrator.AddColumn(new VarChar("email", 100));
            Assert.Throws<Exception>(() => column.SetAutoIncrement());
        }
        
    }
    
}
