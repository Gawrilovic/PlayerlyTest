using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;


namespace Playerly
{
    public class Tests : DriverBase
    {

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            HomePage homepage = new HomePage();
            LoginPage loginpage = new LoginPage(); 

            Driver.Navigate().GoToUrl("https://playerly.net/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
            Driver.Manage().Window.Maximize();

            homepage.SignIn();
            loginpage.InsLogPass("gawrilovic@o2.pl", "xxx$");
            loginpage.ClickSignIn();
            homepage.GoIns();
        }

        [Test]
        public void Test1()
        {

            InsPage inspage = new InsPage();
            OurIns ourins = new OurIns();
            InsPage countins = new InsPage();


            ourins.ShowAllIns();
            ourins.SelecIns("MaTitheone");
            inspage.ShowMoreCoursesIfAvailable();

            Assert.AreEqual(inspage.ReadInsCourseNumbers(), inspage.CountCourses().ToString());
            


        }
        [TearDown]
        public void ChromeClose()
        {
            Driver.Quit();
        }
        
    }
}
