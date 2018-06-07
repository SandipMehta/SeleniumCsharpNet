using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Administrator\Downloads\IEDriverServer_x64_2.52.0");
            driver.Navigate().GoToUrl("https://www.google.co.in/");
            
        }
    }
}
