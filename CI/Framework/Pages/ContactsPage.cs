using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Framework.Pages;
using Framework.Model;
using Framework.Utils;

namespace Framework
{
    public class ContactsPage :BasePage
    {
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement nameFiled;

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement eMailField;

        [FindsBy(How = How.ClassName, Using = "theme-wpcf7-submit")]
        private IWebElement sendButton;

        [FindsBy(How = How.ClassName, Using = "wpcf7-validation-errors")]
        private IWebElement errorMessageAlert;
        [FindsBy(How = How.ClassName, Using = "wpcf7-spam-blocked")]
        private IWebElement errorMessageCapcha;

        public ContactsPage FillInFieldsMessage(Message message)
        {
            Logger.Log.Info("Fill in fields by values" + message.ToString());
            nameFiled.SendKeys(message.Name);
            eMailField.SendKeys(message.Email);
            return this;
        }
        public ContactsPage FillInFieldsUser(User user)
        {
            Logger.Log.Info("Fill in fields by values" + user.ToString());
            nameFiled.SendKeys(user.Name);
            eMailField.SendKeys(user.EMail);
            return this;
        }
        public ContactsPage SendMessage()
        {
            Logger.Log.Info("Send message.");
            sendButton.Click();
            return this;
        }

        public string GetMessageText()
        {
            Logger.Log.Info("Get message text: " + errorMessageAlert.Text);
            return errorMessageAlert.Text;
        }
        public string GetMessageCapcha()
        {
            Logger.Log.Info("Get message text: " + errorMessageCapcha.Text);
            return errorMessageCapcha.Text;
        }

        public override BasePage OpenPage()
        {
            Logger.Log.Info("Open base page.");
            webDriver.Navigate().GoToUrl("https://www.aerostar.by/contacts/");
            return this;
        }

        public ContactsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

    }

}
