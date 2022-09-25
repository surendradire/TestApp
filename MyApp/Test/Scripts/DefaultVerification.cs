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
    public class DefaultVerification
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
        public void VerifyDefaultTitle()
        {
            //System.Threading.Thread.Sleep(20000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30)); // Need to learn - Ramesh
            wait.Until(driver => driver.FindElement(By.Id("HyperLink3")));

            Assert.AreEqual(driver.Title.ToString(), "Welcome");
        }


        [Test]
        public void VerifyDefaultWlecomeMessage()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(driver => driver.FindElement(By.Id("HyperLink3")));

            IWebElement WelcomeMessage = driver.FindElement(By.XPath("//*[@id='form1']/h1")); //Need to learn - Ramesh

            Assert.AreEqual(WelcomeMessage.Text, "Welcome to Accounts");
        }
        
        [Test]
        public void VerifyDefaultSignIn()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(driver => driver.FindElement(By.Id("HyperLink3")));

           // IWebElement WelcomeMessage = driver.FindElement(By.XPath("//*[@id='form1']/h1"));

            IWebElement SignInLink = driver.FindElement(By.Id("HyperLink3"));

            Assert.AreEqual(SignInLink.Text, "SignIn");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        //data provider selenium c# nunit framework - Ramesh
    }
}