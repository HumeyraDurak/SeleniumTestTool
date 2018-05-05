using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestTool
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl("https://www.n11.com/");
        }
    }
}
