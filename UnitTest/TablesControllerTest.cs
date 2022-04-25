using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using АПТ.Controllers;
using System;
using АПТ.Models;
using XAct.Library.Settings;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class TablesControllerTest
    {
        private TehEntities db = new TehEntities();

        [TestMethod]
        public void Create()
        {
            // Arrange
            TablesController controller = new TablesController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        
    }
}
