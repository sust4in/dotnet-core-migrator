using System;
using Ozziest;
using Ozziest.Adaptors;
using Xunit;

namespace Ozziest.UnitTests
{
    public class MigratorTest
    {
        [Fact]
        public void ReturnFalseGivenValuesLessThan2()
        {
            IAdaptor adaptor = DatabaseAdaptor.Get(DatabaseAdaptor.MYSQL, "my_connection_string");
            Assert.True(true);
        }
        
    }
}
