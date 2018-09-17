using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;

namespace Selenium_testing
{
    class TestTemplate
    {
  


            static string url = "http://www.aiub.edu/";
            static IWebDriver driver = new ChromeDriver();
            static string actualtitle = "Home | American International University-Bangladesh (AIUB)";

        

        [TestCase()]
             public void TC_01()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Navigate().GoToUrl(url);
                string windowTitle = driver.Title;


                Assert.AreEqual(actualtitle, windowTitle);
            
        }
        //[TestCase()]
        //public void TC_04_Check_Login_with_invalid_credentials()
        //{

        //    IWebElement campus = driver.FindElement(By.CssSelector("#menu-secondary-navigation > li:nth-child(2) > a"));
        //    campus.Click();


        //    IWebElement username = driver.FindElement(By.CssSelector("#username"));
        //    username.SendKeys("15-28980-1");
        //    IWebElement password = driver.FindElement(By.CssSelector("#password"));
        //    password.SendKeys("Jahin123@");
        //    IWebElement logbutton = driver.FindElement(By.CssSelector("body > div > div > div > div > div:nth-child(2) > form > div:nth-child(4) > button"));
        //    logbutton.Click();
        //}

            
        [TestCase()]
            public void TC_02_Template()
            {
                     IWebElement campus = driver.FindElement(By.ClassName("img-responsive"));
                    campus.Click();

                    string campusPageTitle = driver.FindElement(By.ClassName("header-title")).Text;

      
                    Assert.AreEqual(campusPageTitle, "AIUB CAMPUS");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        }

        [TestCase()]
        public void TC_03_1()

        {
            driver.Navigate().GoToUrl(url);
            IWebElement about = driver.FindElement(By.CssSelector("#menu-primary-navigation > li:nth-child(2) > a"));


            Actions action = new Actions(driver);
            action.MoveToElement(about).Perform();

            if (driver.FindElement(By.LinkText("Information")).Displayed)
            {
                driver.FindElement(By.LinkText("Information")).Click();
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

        }
        [TestCase()]
        public void TC_03_1_1()

        {
            driver.Navigate().GoToUrl(url);
            IWebElement about = driver.FindElement(By.CssSelector("#menu-primary-navigation > li:nth-child(2) > a"));


            Actions action = new Actions(driver);
            action.MoveToElement(about).Perform();

            if (driver.FindElement(By.LinkText("General Information")).Displayed)
            {
                driver.FindElement(By.LinkText("General Information")).Click();
            }

        }
        [TestCase()]
        public void TC_03_1_2()

        {
            driver.Navigate().GoToUrl(url);
            IWebElement about = driver.FindElement(By.CssSelector("#menu-primary-navigation > li:nth-child(2) > a"));


            Actions action = new Actions(driver);
            action.MoveToElement(about).Perform();

            if (driver.FindElement(By.LinkText("Rules of Campus Entry")).Displayed)
            {
                driver.FindElement(By.LinkText("Rules of Campus Entry")).Click();
            }

        }
        [TestCase()]
        public void TC_03_2_1()

        {
            driver.Navigate().GoToUrl(url);
            IWebElement about = driver.FindElement(By.CssSelector("#menu-primary-navigation > li:nth-child(3) > a"));


            Actions action = new Actions(driver);
            action.MoveToElement(about).Perform();

            if (driver.FindElement(By.LinkText("Academic Regulations")).Displayed)
            {
                driver.FindElement(By.LinkText("Academic Regulations")).Click();
            }

        }

        [TestCase()]
        public void TC_03_3_1()

        {
            driver.Navigate().GoToUrl(url);
            IWebElement about = driver.FindElement(By.CssSelector("#menu-primary-navigation > li:nth-child(4) > a"));


            Actions action = new Actions(driver);
            action.MoveToElement(about).Perform();

            if (driver.FindElement(By.LinkText("The Vice Chancellor")).Displayed)
            {
                driver.FindElement(By.LinkText("The Vice Chancellor")).Click();
            }

        }
        [TestCase()]
        public void TC_03_4_1()

        {
            driver.Navigate().GoToUrl(url);
            IWebElement about = driver.FindElement(By.CssSelector("#menu-primary-navigation > li:nth-child(5) > a"));


            Actions action = new Actions(driver);
            action.MoveToElement(about).Perform();

            if (driver.FindElement(By.LinkText("Faculty List")).Displayed)
            {
                driver.FindElement(By.LinkText("Faculty List")).Click();
            }

        }
        [TestCase()]
        public void TC_03_Check_Login_with_valid_credentials()
        {
            IWebElement campus = driver.FindElement(By.CssSelector("#menu-secondary-navigation > li:nth-child(2) > a"));
            campus.Click();

           
            IWebElement username = driver.FindElement(By.CssSelector("#username"));
            username.SendKeys("15-28980-1");
            IWebElement password = driver.FindElement(By.CssSelector("#password"));
            password.SendKeys("");// for security i could not my account password
            IWebElement logbutton = driver.FindElement(By.CssSelector("body > div > div > div > div > div:nth-child(2) > form > div:nth-child(4) > button"));
            logbutton.Click();

        }

        
        
        [TestCase()]
        public void TC_05_Check_Course_Result()
        {
            IWebElement Coursebut = driver.FindElement(By.CssSelector("body > div.container > div.row.ng-scope > nav > div > ul > li:nth-child(1) > a"));
            Coursebut.Click();

        }
        //select from dropdown
        [TestCase()]
        public void TC_06_Check_Specific_Course_Result()
        {
            IWebElement Coursebut = driver.FindElement(By.Name("SectionDropDown"));

            Coursebut.SendKeys("COMPILER DESIGN [E]");

        }

        [TestCase()]
        public void TC_07_Check_Specific_Course_Result()
        {
            IWebElement Coursebut = driver.FindElement(By.Name("SectionDropDown"));

            Coursebut.SendKeys("ADVANCED COMPUTER NETWORKS [A]");

        }
        [TestCase()]
        public void TC_08_Check_Specific_Course_Result()
        {
            IWebElement Coursebut = driver.FindElement(By.Name("SectionDropDown"));

            Coursebut.SendKeys("THESIS (BSCS) [A]");

        }
       
        [TestCase()]
        public void TC_09_Check_Specific_semester()
        {
            IWebElement Coursebut = driver.FindElement(By.Name("SemesterDropDown"));

            Coursebut.SendKeys("2014-2015, Spring");

        }
        [TestCase()]
        public void TC_11_Check_Registration()
        {
            IWebElement Coursebut1 = driver.FindElement(By.CssSelector("body > div.container > div.row.ng-scope > nav > div > ul > li:nth-child(2) > a"));
            Coursebut1.Click();

        }
        [TestCase()]
        public void TC_12_grade_Report()
        {
            IWebElement Coursebut1 = driver.FindElement(By.CssSelector("body > div.container > div.row.ng-scope > nav > div > ul > li:nth-child(3) > a"));
            Coursebut1.Click();

        }
        [TestCase()]
        public void TC_14_profile()
        {
            IWebElement Coursebut1 = driver.FindElement(By.ClassName("navbar-link"));
            Coursebut1.Click();

        }
        
        
        //[TestCase()]
        //public void TC_13_grade_Report_print()
        //{
        //    IWebElement Coursebut1 = driver.FindElement(By.CssSelector("#main-content > div > div.panel-heading > h5 > div > div.col-md-2.col-xs-12 > a > div"));
        //    Coursebut1.Click();

        //}


    }
}



