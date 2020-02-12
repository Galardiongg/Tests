using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using Framework.Pages;
using Framework.Utils;
using Framework.Model;
using System.Threading;

namespace Framework
{
    public class AviaPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@href='/contacts/']")]
        private IWebElement navigationMenuLinkContacts;

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-begin")]
        private IWebElement rentalDateStart;

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-end")]
        private IWebElement rentalDateEnd;

        [FindsBy(How = How.Id, Using = "block-home-search_button-search")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "wpcf7-response-output")]
        private IWebElement errorMessageAlert;

        public AviaPage(IWebDriver webDriver):base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }


        public OrdersListPage ClickSubmitButton()
        {
            Logger.Log.Info("Submit filter (ClickSubmitButton)");
            submitButton.Click();
            return new OrdersListPage(this.webDriver);
        }

        public string GetErrorMessageText()
        {
            Logger.Log.Info("Get error text: " + errorMessageAlert.Text);
            return errorMessageAlert.Text;
        }
        
        public ContactsPage GoToContactsPage()
        {
            Logger.Log.Info("Go to contacts page");
            navigationMenuLinkContacts.Click();
            return new ContactsPage(this.webDriver);
        }

        public override BasePage OpenPage()
        {
            Logger.Log.Info("Open strat page.");
            webDriver.Navigate().GoToUrl("https://www.aerostar.by/services/air-carriages/");
            return this;
        }
    }
}
