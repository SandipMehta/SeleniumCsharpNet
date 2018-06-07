using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;


namespace Demo1
{
    [TestClass]
    public class Test1
    {
        IWebDriver driver;
        IWebElement query;

        [TestMethod]
        public void TestMethod1()
        {
            //driver = new FirefoxDriver();
            //driver = new ChromeDriver(@"C:\Users\Administrator\Downloads\chromedriver_win32");
            driver = new InternetExplorerDriver(@"C:\Users\Administrator\Downloads\IEDriverServer_x64_2.52.0");
            driver.Manage().Window.Maximize();
            
            driver.Navigate().GoToUrl("http://www.google.com/");
            
            query = driver.FindElement(By.Name("q"));
            query.SendKeys("Hello World");
            driver.FindElement(By.Name("btnG")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            //driver.FindElement(By.LinkText("Speedtest.net by Ookla - The Global Broadband Speed Test")).Click();
            driver.FindElement(By.XPath(".//*[@id='rso']/div/div[1]/div/h3/a")).Click();

            //driver.Navigate().GoToUrl("http://192.168.1.91/SitePages/Home.aspx");
        }
    }
}
