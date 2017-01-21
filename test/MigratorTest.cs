using System;
using Ozziest;
using Xunit;

namespace Ozziest.UnitTests
{
    public class MigratorTest
    {
        [Fact]
        public void ReturnFalseGivenValuesLessThan2()
        {
            Migrator service = new Migrator();
            Assert.False(service.IsReady());
        }
        
    }
}
