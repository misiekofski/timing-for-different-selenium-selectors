using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObjects.SelectorsSelenium
{
    public class CssCheckoutPage
    {
        private IWebDriver driver;

        private By formLocator => By.CssSelector("form.needs-validation");
        private IWebElement form => driver.FindElement(formLocator);

        private By firstNameLocator => By.CssSelector("input.first-name");
        private IWebElement firstName => form.FindElement(firstNameLocator);

        private By lastNameLocator => By.CssSelector("input.last-name");
        private IWebElement lastName => form.FindElement(lastNameLocator);

        private By usernameLocator => By.CssSelector("input.username");
        private IWebElement userName => form.FindElement(usernameLocator);


        private By emailLocator => By.CssSelector("input.email");
        private IWebElement eMail => form.FindElement(emailLocator);

        private By addressLocator => By.CssSelector("input.address");
        private IWebElement address1 => form.FindElement(addressLocator);

        private By address2Locator => By.CssSelector("input.address2");
        private IWebElement address2 => form.FindElement(address2Locator);

        private By shipSameAdressLocator => By.CssSelector("label.same-address");
        private IWebElement shipSameAdress => form.FindElement(shipSameAdressLocator);

        private By debitCardLocator => By.CssSelector("label.debit");
        private IWebElement debitCard => form.FindElement(debitCardLocator);

        private By submitButtonLocator => By.CssSelector("button.continue-to-checkout");
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

        public CssCheckoutPage(IWebDriver _driver)
        {
            driver = _driver;
        }

    }
}
