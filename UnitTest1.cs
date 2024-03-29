using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace QATest
{
    class NUintTest
    {
        RemoteWebDriver driver;
        static string URL;
        [SetUp]
        public void Initialize()
        {
            URL = "https://www.msn.com/";
            ChromeOptions options = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri(Environment.GetEnvironmentVariable("GRID")), options.ToCapabilities(), TimeSpan.FromSeconds(15));
        }

        [Test]
        public void OpenAppGoogle()
        {
            driver.Url = "http://www.google.com/";
        }

        [Test]
        public void OpenAppNotExist()
        {
            driver.Url = "http://www.fghjtfgyhuijftgyhuyghuji.com/";
        }

        [Test]
        public void OpenAppMSN()
        {
            driver.Url = URL;
            driver.GetScreenshot().SaveAsFile("bbc.png");
        }

        [Test]
        public void OpenNamedApp()
        {
            driver.Url = Environment.GetEnvironmentVariable("URL");
        }

        [Test]
        public void RandomFailure()
        {
            Assert.Greater(DateTime.Now.Second, 30);
        }
        
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
