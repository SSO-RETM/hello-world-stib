using HelloWorldSTIB.Pages;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hello_world_stib_test
{
    public class UnitTest1
    {

        AboutModel _aboutmodel = new AboutModel();
  
        [Fact]
        public void Test1()
        {
            // Act
            string message = _aboutmodel.Message;
            _aboutmodel.Message = "hello";
           
            // Assert
           // Assert.Equal("hello", message);
            Assert.Null(message);
        }
    }
}
