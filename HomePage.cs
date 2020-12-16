using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playerly
{
    class HomePage : DriverBase
    {
        IWebElement LnkLogin => Driver.FindElement(By.XPath("//a[@Class='btn btn-outline-primary']"));
        IWebElement LnkOurIns => Driver.FindElement(By.XPath("//a[@class='nav-link nav-blog text-dark']"));
        public void SignIn()
        {
           
            LnkLogin.Click();
        }

        public  void GoIns()
        {

            LnkOurIns.Click();
        }
               
    }
}
