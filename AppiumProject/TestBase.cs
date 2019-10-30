using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AppiumProject
{
    [TestFixture]
    public class TestBase
    {
        //Creating Instance of Appium Driver
        protected static AppiumDriver<AndroidElement> driver;

        [OneTimeSetUp]
        public void Init()
        {
            AppiumOptions opt = new AppiumOptions();
            //DesiredCapabilities cap = new DesiredCapabilities();
            opt.AddAdditionalCapability("platformName", "Android");
            opt.AddAdditionalCapability("deviceName", "Demo");
            opt.AddAdditionalCapability("appPackage", "com.google.android.gm");
            opt.AddAdditionalCapability("appActivity", ".ConversationListActivityGmail");

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), opt);

            
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
