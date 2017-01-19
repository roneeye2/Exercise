using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GloboMart.Service.Order;
using GloboMart.Service.Order.Controllers;
using GloboMart.Framwork.Container;
using Microsoft.Practices.Unity;

namespace GloboMart.Service.Order.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        private ValuesController controller = Bootstrapper.Initialise().Resolve<ValuesController>();

        [TestMethod]
        public void Get()
        {
            // Arrange

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
