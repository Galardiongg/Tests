using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Test;
using Framework.Services;
using Framework.Model;
using Framework.Utils;

namespace Framework.Test
{
    [TestFixture]
    public class ConsultationFormTest : CommonConditions
    {
        [Test]
        [Category("ContactFormTest")]
        public void SendBlankEMail()
        {
            Logger.Log.Info("Start SendBlankEMail unit test.");
            string expectingMessage = ErrorCreater.MessageWithEmptyFields();


            string errorMessage = (new AviaPage(webDriver).OpenPage() as AviaPage)
                                                .GoToContactsPage()
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("ContactFormTest")]
        public void SendEMailIncorrectEMailAdr()
        {
            Logger.Log.Info("Start SendEMailIncorrectEMailAdr unit test.");

            string expectingMessage = ErrorCreater.MessageWithInvalidEMail();

            Message message = MessageCreater.WithAllProperties();

            string errorMessage = (new AviaPage(webDriver).OpenPage() as AviaPage)
                                                .GoToContactsPage()
                                                .FillInFieldsMessage(message)
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("ContactFormTest")]
        public void ValidEmaildAndName()
        {
            Logger.Log.Info("Start ValidEmaildAndName unit test.");
            string expectingMessage = ErrorCreater.MessageWithValidEMail();
            string errorMessage = (new AviaPage(webDriver).OpenPage() as AviaPage)
                                               .GoToContactsPage()
                                               .FillInFieldsUser(UserCreater.RegisteredUser())
                                               .SendMessage()
                                               .GetMessageCapcha();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
    }
}