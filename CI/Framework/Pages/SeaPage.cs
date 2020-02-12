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
    public class SeaPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "departure_city")]
        private IWebElement startCountry;
        [FindsBy(How = How.Name, Using = "delivery_city")]
        private IWebElement endCountry;
        [FindsBy(How = How.Name, Using = "weight")]
        private IWebElement weight;
        [FindsBy(How = How.Name, Using = "size")]
        private IWebElement size;
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement eMailField;
        [FindsBy(How = How.Name, Using = "tel-882")]
        private IWebElement phoneNumber;
        [FindsBy(How = How.ClassName, Using = "theme-wpcf7-submit")]
        private IWebElement costButtton;

        [FindsBy(How = How.ClassName, Using = "wpcf7-validation-errors")]
        private IWebElement errorMessage;
        [FindsBy(How = How.ClassName, Using = "wpcf7-spam-blocked")]
        private IWebElement errorMessageCapcha;
        public SeaPage FillInFields(User user)
        {
            Logger.Log.Info("Fill in fields:" + user.ToString());
            startCountry.SendKeys(user.StartCountry);
            endCountry.SendKeys(user.EndCountry);
            weight.SendKeys(user.Weight);
            size.SendKeys(user.Size);
            eMailField.SendKeys(user.EMail);
            phoneNumber.SendKeys(user.PhoneNumber);
            return this;
        }

        public SeaPage(IWebDriver webDriver):base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        public SeaPage Submit()
        {
            Logger.Log.Info("FindCost.");
            costButtton.Click();
            return this;
        }

        public string GetErrorMessage()
        {
            try
            {
                Logger.Log.Info("Get message text: " + errorMessage.Text);

                return errorMessage.Text;
            }
            catch (WebDriverException wdEx)
            {
                Logger.Log.Info("Get message text: no error message");
                return "";
            }
            catch (Exception ex)
            {
                Logger.Log.Info(ex.Message);
                return "";
            }
        }
        public string GetMessageCapcha()
        {
            Logger.Log.Info("Get message text: " + errorMessageCapcha.Text);
            return errorMessageCapcha.Text;
        }

        public override BasePage OpenPage()
        {
            Logger.Log.Info("Open strat page.");
            webDriver.Navigate().GoToUrl("https://www.aerostar.by/services/sea-carriages/");
            return this;
        }
    }
}
