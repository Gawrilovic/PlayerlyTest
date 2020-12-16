using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playerly
{
    public class WaitCustomControl : DriverBase

    {
        public static void WaitForElement(IWebElement webelement)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementToBeClickable(webelement));
        }

    }
}



