using Microsoft.VisualStudio.TestTools.UnitTesting;
using АПТ.Controllers;
using System.Web.Mvc;
using System;

namespace UnitTest
{
    [TestClass]
    public class Test {
        private TestController controller;
        private ViewResult result;

        [TestInitialize]
        public void SetupContext()
        {
            controller = new TestController();
            result = controller.Index() as ViewResult;
        }

        [TestMethod]
        public void IndexViewResultNotNull()
        {
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            Assert.AreEqual("Index", result.ViewName);
        }

    }
}
