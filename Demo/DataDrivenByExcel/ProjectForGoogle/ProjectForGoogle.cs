using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using AutoItX3Lib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Linq;
using System.Collections;
using System.Diagnostics;




namespace ProjectForGoogle
{
    [TestClass]
    public class ProjectForGoogle
    {       
        static IWebDriver driver = new FirefoxDriver();
        Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        Microsoft.Office.Interop.Excel.Range xlrange;
        Excel.Sheets excelSheets;
        string currentSheet = "Sheet1";
        [TestMethod]
        public void Setup()
        {


            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http:demo5@eshibaan.local:Admin@1234@10.33.36.42/Pages/Screenshot.aspx");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            ExcelRead();
            Console.WriteLine("Start Writing");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Console.WriteLine("Start Writing - After Wait");
            ExcelWrite();
        }

        public void ExcelRead()
        {
            string xlString = string.Empty;           
            if (xlApp == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }

            xlWorkBook = xlApp.Workbooks.Open("C:\\Nidhi\\3.xlsx");
            excelSheets = xlWorkBook.Sheets;
            xlWorkSheet = (Excel.Worksheet)excelSheets.get_Item(currentSheet);


            xlrange = xlWorkSheet.UsedRange;
            ReadOnlyCollection<IWebElement> list1 = driver.FindElements(By.XPath(".//input[contains(@id,'ctl00_SPWebPartManager1_g_')]"));
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath(".//input[contains(@id,'ctl00_SPWebPartManager1_g_')]"));
            driver.FindElement(By.XPath("(//a[contains(@href, 'javascript:void(0)')])[7]")).Click();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Clear();
            }
            for (int rCnt = 2; rCnt <= xlrange.Rows.Count; rCnt++)
            {
                for (int cCnt = 1; cCnt < 2; cCnt++)
                {
                    xlString = (string)(xlrange.Cells[rCnt, cCnt] as Excel.Range).Value2;

                }
                if (!string.IsNullOrEmpty(xlString))
                    list[rCnt - 2].SendKeys(xlString);
            }

            driver.FindElement(By.XPath("//*[contains(@id,'ctl00_SPWebPartManager1_g_') and contains(@id,'_ctl00_aterastockTickerSubmit')]")).Click();
            xlWorkBook.Close(true);
            Console.WriteLine("Excel Close - Read");
            xlApp.Quit();
            Console.WriteLine("Excel Quit - Read");
           //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlrange);
           // System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
           // System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
           // System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
           // Console.WriteLine("Excel Release - Read");
            
        }

        public void ExcelWrite()
        {
            ReadOnlyCollection<IWebElement> Value = driver.FindElements(By.ClassName("atera-stockInfo"));
            Console.WriteLine("Excel Write Called");
            {
                int j = 2;
                
                xlWorkBook = xlApp.Workbooks.Open("C:\\Nidhi\\3.xlsx");
                Console.WriteLine("Open");
                excelSheets = xlWorkBook.Sheets;
                xlWorkSheet = (Excel.Worksheet)excelSheets.get_Item(currentSheet);
                Console.WriteLine("Open Excel - Write");
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
                
                foreach (var val1 in Value)
                {
                    Debug.WriteLine("Start For - Write");
                    Debug.WriteLine(val1.Text.ToString());
                    
                    string printVal = string.Empty;
                    string printVal1 = string.Empty;
                    if (val1.Text.Contains("+"))
                    {
                        printVal = val1.Text.Split('+')[0].ToString();
                        printVal1 = "+" + val1.Text.Split('+')[1].ToString();
                        Console.WriteLine("+ Excel - Write");
                    }
                    else if (val1.Text.Contains("-"))
                    {
                        Console.WriteLine(val1.Text.Contains("-"));
                        printVal = val1.Text.Split('-')[0].ToString();
                        printVal1 = "-" + val1.Text.Split('-')[1].ToString();
                        Console.WriteLine("- Excel - Write");
                    }
                    xlWorkSheet.Cells[j, 2] = printVal;
                    xlWorkSheet.Cells[j, 3] = printVal1;
                    Console.WriteLine(j);                    
                    j++;
                }

                xlWorkBook.Close(true);
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                    
            }
        }

    }
}
