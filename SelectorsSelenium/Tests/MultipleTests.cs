using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects.SelectorsSelenium;
using System;
using System.Diagnostics;
using System.Text;

namespace SelectorsSelenium
{
    public class XpathTests : BaseTest
    {
        [Test]
        public void TestTimingForXpaths()
        {
            var firstname = "Jan";
            var lastname = "Kowalski";
            var username = "jankowalski";
            var email = "jan@kowalski.com";
            var address = "Wrocuaff";

            Stopwatch stopwatch = Stopwatch.StartNew();

            var xpathPage = new XpathCheckoutPage(driver);
            xpathPage.FillCheckoutForm(firstname, lastname, username, email, address);

            stopwatch.Stop();

            sb.Append("Xpath Test took: " + stopwatch.ElapsedMilliseconds + "\n\r" );
        }

        [Test]
        public void TestTimingForCssSelectors()
        {
            var firstname = "Jan";
            var lastname = "Kowalski";
            var username = "jankowalski";
            var email = "jan@kowalski.com";
            var address = "Wrocuaff";

            Stopwatch stopwatch = Stopwatch.StartNew();

            var cssPage = new CssCheckoutPage(driver);
            cssPage.FillCheckoutForm(firstname, lastname, username, email, address);

            stopwatch.Stop();

            sb.Append("CSSSelectors Test took: " + stopwatch.ElapsedMilliseconds + "\n\r");
        }

    }
}