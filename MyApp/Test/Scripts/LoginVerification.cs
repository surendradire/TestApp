using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Services.Impl;
using Assert = NUnit.Framework.Assert;

namespace Test.Scripts
{
    [TestClass]
    public class LoginVerification
    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            if (Test.Constants.BrowserType == "chrome")
            {
                driver = new ChromeDriver();
            }
            else
            {
                //driver = new EdgeDriver();
            }

            driver.Navigate().GoToUrl("http://localhost:5555/Accounts/Default.aspx");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyLogin()
        {

            IWebElement SignIn = driver.FindElement(By.LinkText("SignIn"));
            SignIn.Click();

            //driver.FindElement(By.LinkText("SignIn")).Click();

            driver.FindElement(By.Id("TextBox2")).SendKeys("test1");

            driver.FindElement(By.Id("TextBox1")).SendKeys("test1");

            driver.FindElement(By.Id("Submit")).Click();

        }

        public void VerifyLogin_Nagative()
        {

            IWebElement SignIn = driver.FindElement(By.LinkText("SignIn"));
            SignIn.Click();

            //driver.FindElement(By.LinkText("SignIn")).Click();

            driver.FindElement(By.Id("TextBox2")).SendKeys("test1");

            driver.FindElement(By.Id("TextBox1")).SendKeys("test2");

            driver.FindElement(By.Id("Submit")).Click();

            //Assert.AreEqual()


        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}