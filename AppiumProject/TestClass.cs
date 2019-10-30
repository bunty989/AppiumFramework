using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumProject
{
    class TestClass : TestBase
    {

        [Test]
        public void OpenGmail()
        {
            Assert.IsNotNull(driver.Context);
        }

        [Test]
        public void TypeNumber()
        {

        }
    }
}
