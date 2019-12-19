using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace SelectorsSelenium
{
    public class BaseTest
    {

        public static IWebDriver driver;
        public static StringBuilder sb = new StringBuilder();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "file:///C:/Users/MichalDobrzycki/source/repos/SelectorsSelenium/SelectorsSelenium/www/index.html";
        }


        [TearDown]
        public void TearDown()
        {
            Console.WriteLine(sb.ToString());
            driver.Close();
        }
    }
}
