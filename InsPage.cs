using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Playerly  
{
    public class InsPage : DriverBase
    {


        IWebElement InsCourseNumber => Driver.FindElement(By.XPath("//body/app-root[1]/app-single-instructor[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/h2[1]"));
        IWebElement ShowMoreButton => Driver.FindElement(By.XPath("//button[contains(text(),'Show more')]"));

        public void ShowMoreCoursesIfAvailable()
        {
            WaitCustomControl.WaitForElement(ShowMoreButton);

            if (Driver.PageSource.Contains("Show more"))
            {
               
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", ShowMoreButton);
                Thread.Sleep(2000);
            }

        }
        public string ReadInsCourseNumbers()
        {
            string coursenumber;
            coursenumber = InsCourseNumber.Text;
            return coursenumber;

        }
        public int CountCourses()
        {
            int coursecount = Driver.FindElements(By.XPath("//div[@class='col mb-4']")).Count();
            return coursecount;

        }





    }
}
