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
            driver = new RemoteWebDriver(new Uri("http://10.209.124.131:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(15));
        }

        [Test]
        public void OpenAppGoogle()
        {
            driver.Url = "http://www.google.com/";
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
            driver.Url = Environment.GetEnvironmentVariable("URL") ;
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
