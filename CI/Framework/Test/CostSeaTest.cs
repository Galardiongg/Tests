using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Test;
using Framework.Services;
using Framework.Pages;
using Framework.Utils;

namespace Framework.Test
{
    [TestFixture]
    public class CostSeaTest : CommonConditions
    {
        [Test]
        [Category("CostSeaTest")]
        public void CreateFieldCostAsRegistratedUser()
        {
            Logger.Log.Info("Start CreateFieldCostAsRegistratedUser unit test.");

            string expectingMessage = ErrorCreater.CorrectData();


            string errorMessage = (new SeaPage(webDriver).OpenPage() as SeaPage)
                                    .FillInFields(UserCreater.RegisteredUser())
                                    .Submit()
                                    .GetMessageCapcha();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("CostSeaTest")]
        public void CreateFieldCostIncorrectEmail()
        {
            Logger.Log.Info("Start CreateFieldCostIncorrectEmail unit test.");

            string expectingMessage = ErrorCreater.WithoutCorrectData();


            string errorMessage = (new SeaPage(webDriver).OpenPage() as SeaPage)
                                    .FillInFields(UserCreater.IncorrectEmailRegisteredUser())
                                    .Submit()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("CostSeaTest")]
        public void CreateFieldCostIncorrectPhone()
        {
            Logger.Log.Info("Start CreateFieldCostIncorrectPhone unit test.");

            string expectingMessage = ErrorCreater.WithoutCorrectData();


            string errorMessage = (new SeaPage(webDriver).OpenPage() as SeaPage)
                                    .FillInFields(UserCreater.IncorrectPhoneRegisteredUser())
                                    .Submit()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("CostSeaTest")]
        public void WithoutDataCostTest()
        {
            Logger.Log.Info("Start ButtonCostTest unit test.");
            string expectingMessage = ErrorCreater.WithoutCorrectData();

            string errorMessage = (new SeaPage(webDriver).OpenPage() as SeaPage)
                                    .Submit()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);

        }
    }
}
