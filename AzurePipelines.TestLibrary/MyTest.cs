using System;
using Xunit;

namespace AzurePipelines.TestLibrary
{
    public class MyTest
    {
        [Fact]
        public void Succeed()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Fail()
        {
            Assert.False(1 == 2);
        }
    }
}
