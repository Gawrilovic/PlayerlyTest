using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Playerly
{
    public class OurIns : DriverBase
    {
        IWebElement SeeMore => Driver.FindElement(By.XPath("//a[contains(text(),'See more')]"));

        public void ShowAllIns()

        {

            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", SeeMore); ;

        }
        public void SelecIns(string ins)
        {
            IWebElement instructor = Driver.FindElement(By.XPath($"//h5[contains(text(),'{ins}')]"));
            
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", instructor);
        }
    }
}
