using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestTool
{
    class Program
    {
        static void Main(string[] args)
        {            
            IWebDriver webDriver = new ChromeDriver("C:\\Users\\w7\\Desktop\\SeleniumTestTool\\ClassLibrary1");
            webDriver.Navigate().GoToUrl("https://www.n11.com/");

            webDriver.FindElement(By.ClassName("btnSignIn")).Click();
            webDriver.FindElement(By.Id("email")).SendKeys("humeyra.golyeri@gmail.com");
            webDriver.FindElement(By.Id("password")).SendKeys("Password1");
            webDriver.FindElement(By.Id("loginButton")).Click();

            webDriver.FindElement(By.Id("searchData")).SendKeys("Samsung");
            webDriver.FindElement(By.ClassName("searchBtn")).Click();

            webDriver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")).Click();
            webDriver.FindElement(By.XPath(".//*[@id='contentListing']/div[1]/div[1]/div[2]/div[2]"));

            webDriver.FindElement(By.XPath(".//*[@id='p-253143910']/div[2]/span[1]")).Click();
            webDriver.FindElement(By.XPath(".//*[@class='hMenu']/div[2]/div[2]/div[2]/div[2]/div/a[2]")).Click();
            webDriver.FindElement(By.XPath(".//*[@class='listItemWrap']/a[1]/h[4]")).Click();
        }
    }
}   