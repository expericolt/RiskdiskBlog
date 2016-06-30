using InterviewPracticalMVCTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace IntegrationTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_LoadsView()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
