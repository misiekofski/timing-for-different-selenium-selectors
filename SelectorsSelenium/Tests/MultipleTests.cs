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
        public void Xpath1_TestTiming()
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

            sb.Append("Xpath first Test took: " + stopwatch.ElapsedMilliseconds + "\n\r" );
        }

        [Test]
        public void Xpath2_TestTiming()
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

            sb.Append("Xpath second Test took: " + stopwatch.ElapsedMilliseconds + "\n\r");
        }

        [Test]
        public void Xpath3_TestTiming()
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

            sb.Append("Xpath third Test took: " + stopwatch.ElapsedMilliseconds + "\n\r");
        }

        [Test]
        public void CSS1_TestTiming()
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

            sb.Append("CSSSelectors first Test took: " + stopwatch.ElapsedMilliseconds + "\n\r");
        }

        [Test]
        public void CSS2_TestTiming()
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

            sb.Append("CSSSelectors second Test took: " + stopwatch.ElapsedMilliseconds + "\n\r");
        }

        [Test]
        public void CSS3_TestTiming()
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

            sb.Append("CSSSelectors third Test took: " + stopwatch.ElapsedMilliseconds + "\n\r");
        }

    }
}