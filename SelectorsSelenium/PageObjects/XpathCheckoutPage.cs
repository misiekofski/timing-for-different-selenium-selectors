using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.SelectorsSelenium
{
    public class XpathCheckoutPage
    {
        private IWebDriver driver;

        private By formLocator => By.XPath("//form[@class='needs-validation']");
        private IWebElement form => driver.FindElement(formLocator);

        private By firstNameLocator => By.XPath(".//input[@id='firstName']");
        private IWebElement firstName => form.FindElement(firstNameLocator);

        private By lastNameLocator => By.XPath(".//input[@id='lastName']");
        private IWebElement lastName => form.FindElement(lastNameLocator);

        private By usernameLocator => By.XPath(".//input[@id='username']");
        private IWebElement userName => form.FindElement(usernameLocator);


        private By emailLocator => By.XPath(".//input[@id='email']");
        private IWebElement eMail => form.FindElement(emailLocator);

        private By addressLocator => By.XPath(".//input[@id='address']");
        private IWebElement address1 => form.FindElement(addressLocator);

        private By address2Locator => By.XPath(".//input[@id='address2']");
        private IWebElement address2 => form.FindElement(address2Locator);

        private By shipSameAdressLocator => By.XPath(".//label[@for='same-address']");
        private IWebElement shipSameAdress => form.FindElement(shipSameAdressLocator);

        private By debitCardLocator => By.XPath(".//label[@for='debit']");
        private IWebElement debitCard => form.FindElement(debitCardLocator);

        private By submitButtonLocator => By.XPath(".//button[@id='continue-to-checkout']");
        private IWebElement submitButton => form.FindElement(submitButtonLocator);
        
        public void FillCheckoutForm(string firstname, string lastname, string username, string email, string address)
        {
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            userName.SendKeys(username);
            eMail.SendKeys(email);
            address1.SendKeys(address);
            address2.SendKeys(address);
            shipSameAdress.Click();
            debitCard.Click();
            submitButton.Click();
        }

        public XpathCheckoutPage(IWebDriver _driver)
        {
            driver = _driver;
        }

    }
}
