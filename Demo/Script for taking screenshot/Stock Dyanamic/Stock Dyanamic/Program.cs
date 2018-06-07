using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using System.IO;
using System.Collections;
using System.Drawing.Imaging;
using System.Drawing;



namespace Stock_Dyanamic
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            IWebElement query = null;

            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http:demo5@eshibaan.local:Admin@1234@10.33.36.42/Pages/Automation.aspx");

          driver.FindElement(By.XPath("//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_aterastockSymbol1')]")).SendKeys("B");
           driver.FindElement(By.XPath("//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_aterastockSymbol2')]")).SendKeys("A");
           driver.FindElement(By.XPath("//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_aterastockSymbol3')]")).SendKeys("C");
           driver.FindElement(By.XPath("//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_aterastockSymbol4')]")).SendKeys("D");
           driver.FindElement(By.XPath("//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_aterastockTickerSubmit')]")).Click();
           //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));

           /*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
    {
        return d.FindElement(By.XPath(".//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_ateraStockTickerWP')]/div[2]/div[1]/a/div/span"));
    });
            */
           driver.Navigate().Refresh();
           Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
           //ss.SaveAsFile("C:\\Dimple\\dk\\my45.png", System.Drawing.Imaging.ImageFormat.Png);

           ss.SaveAsFile("My.png", System.Drawing.Imaging.ImageFormat.Png);

        
        }
    }
}
