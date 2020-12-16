using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playerly
{
    public class LoginPage : DriverBase
    {
        IWebElement TxtLogin => Driver.FindElement(By.XPath("//input[@id='email']"));
        IWebElement TxtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement TxtSignin => Driver.FindElement(By.Id("next"));


        public void InsLogPass(string log, string pass)

            
        {

            TxtLogin.SendKeys(log);
            TxtPassword.SendKeys(pass);

        }
        public void ClickSignIn()
        {
            
            TxtSignin.Click();
        }
    }
}
