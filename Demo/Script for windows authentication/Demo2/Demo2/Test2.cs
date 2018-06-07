using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;


namespace Demo2
{
    [TestClass]
    public class Test2
    {
        IWebDriver driver;
        IWebElement query;

        [TestMethod]
        public void TestMethod1()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://192.168.1.91/Pages/DK.aspx");

            

            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            //driver.Navigate().GoToUrl("http:demo5@eshibaan.local:Admin@1234@10.33.36.42/SitePages/Automation.aspx");
            driver.Navigate().GoToUrl("http://192.168.1.91/Pages/DK.aspx");
            Process.Start("C:\\Users\\Administrator\\Desktop\\UserPass\\User.exe");

           // driver.FindElement(By.Id("Ribbon.WikiPageTab-title")).Click();
            //driver.FindElement(By.ClassName("ms-cui-ctl-a2")).Click();
            //driver.Navigate().GoToUrl("http:dimplek@eshibaan.local:Atera#1@10.33.36.42/sites/DK1/SitePages/Home.aspx");
           //var AutoIT = new AutoIT();

            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(2));

            //try
           //{
           //     driver.Url = "http://192.168.1.91/Pages/DK.aspx";
           // }

           // catch
           // {
             //   return; 
           // }

            //AutoIT.WinWait("Authentication Required");
           // AutoIT.WinActivate("Authentication Required");
           // AutoIT.Send("emg\administrator");
            //AutoIT.Send("{TAB}");
            //AutoIT.Send("AteraPrime#1");
            //AutoIT.Send("{ENTER}");

            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(-1));
            
            
            
            // Process notepad = new Process();
            //notepad.StartInfo.FileName = "C:\Users\Administrator\Desktop\UserPass\User.exe";
            //notepad.Start();
            
            // System.Diagnostics.Process.Start("C:\Users\Administrator\Desktop\UserPass\User.exe");
            //driver.FindElement(By.Id("UserName")).SendKeys("emg\administrator");
            //driver.FindElement(By.Id("Password")).SendKeys("AteraPrime#1");
        }
    }
}
