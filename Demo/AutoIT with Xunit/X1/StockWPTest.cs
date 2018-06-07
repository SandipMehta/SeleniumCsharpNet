using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

using OpenQA.Selenium.Support.UI;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;


namespace TestAutomation
{
    [TestClass]
    public class StockWPTest
    {
        public static IWebDriver driver;
        public StringBuilder verificationErrors;
        public bool acceptNextAlert = true;
        public IWebElement query;

        [Fact]
        public void TestMethod1()
        {

            PrimeConstants pc = new PrimeConstants();
            Browsers br = new Browsers();
            CoreLIbrary cl = new CoreLIbrary();
            driver = br.browsers(pc.glurl, "IE", driver);
            
            

            //cl.callImplicitWait(30, driver);
            //query = driver.FindElement(By.Name("q"));

            //query.SendKeys("Hello World");

            //driver.FindElement(By.Name("btnG")).Click();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //driver.FindElement(By.XPath(".//*[@id='rso']/div/div[1]/div/h3/a")).Click();

        }

    }
}
