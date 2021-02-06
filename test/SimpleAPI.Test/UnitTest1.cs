using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        Controller controller = new Controller();
        [Fact]
        public void GetSomethingElse(){
            var returnValue = controller.Get(1);
            Assert.Equal("something else", returnValue.Value);
        }

        [Fact]
        public void GetValue1Value2()
        {
            var returnValue = controller.Get();
            var re = new string[] {"value1", "value2"};
            Assert.Equal(re, returnValue.Value);

        }
    }
}
