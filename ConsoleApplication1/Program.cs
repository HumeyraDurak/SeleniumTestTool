using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\Users\\w7\\Desktop\\SeleniumTestTool\\ClassLibrary1");

            driver.Url = "http://www.n11.com";
        }

      
    }
}
