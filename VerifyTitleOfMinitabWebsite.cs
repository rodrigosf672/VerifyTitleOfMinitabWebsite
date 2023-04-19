using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VerifyTitleOfMinitabWebsite
{
    public class MinitabWebsiteTitleVerification
    {
        IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

            Driver.Manage().Cookies.DeleteAllCookies();

            Driver.Manage().Window.Maximize();

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Driver.Url = "https://minitab.com";
        }

        [Test]
        public void VerifyTitleOfThePage()
        {
            string expectedTitle = "Data Analysis, Statistical & Process Improvement Tools | Minitab";

            string actualTitle = Driver.Title;

            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    
    }
}