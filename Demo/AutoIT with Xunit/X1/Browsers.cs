using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace TestAutomation
{
    public class Browsers
    {
        public IWebDriver browsers(string url, string name, IWebDriver driver)
        {
            
            if (name == "IE")
            {
                 
                var path = AppDomain.CurrentDomain.BaseDirectory;
             
                driver = new InternetExplorerDriver(path);
                //driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(url);
                Process.Start(path + "\\User.exe");
               
            }
            return driver;
        }

    }
}
