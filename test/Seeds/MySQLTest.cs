using System;
using Ozziest.Columns;
using Ozziest.Columns.String;
using Ozziest.Generators;
using Xunit;
using Ozziest.Generators.MySQL;

namespace test.Seeds
{
    public class MySQLTest
    {

        private IDataGenerator generator = new MySQLDataGenerator();

        [Fact]
        public void TestCreate()
        {
            string sql = generator.Insert("users", new System.Collections.Generic.Dictionary<string, dynamic>()
            {
                { "name", "foo" },
                { "surname", "bar" },
            });
            Assert.Equal("", sql);
        }

    }
}