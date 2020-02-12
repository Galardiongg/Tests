using Framework.Pages;
using Framework.Services;
using Framework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Test
{
    [TestFixture]
    public class CostAviaTest : CommonConditions
    {
        [Test]
        [Category("CostAviaTest")]
        public void CreateFieldCostAsRegistratedUser()
        {
            Logger.Log.Info("Start CreateFieldCostAsRegistratedUser unit test.");

            string expectingMessage = ErrorCreater.CorrectData();


            string errorMessage = (new CostPage(webDriver).OpenPage() as CostPage)
                                    .FillInFields(UserCreater.RegisteredUser())
                                    .Submit()
                                    .GetMessageCapcha();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("CostAviaTest")]
        public void CreateFieldCostIncorrectEmail()
        {
            Logger.Log.Info("Start CreateFieldCostIncorrectEmail unit test.");

            string expectingMessage = ErrorCreater.WithoutCorrectData();


            string errorMessage = (new CostPage(webDriver).OpenPage() as CostPage)
                                    .FillInFields(UserCreater.IncorrectEmailRegisteredUser())
                                    .Submit()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("CostAviaTest")]
        public void CreateFieldCostIncorrectPhone()
        {
            Logger.Log.Info("Start CreateFieldCostIncorrectPhone unit test.");

            string expectingMessage = ErrorCreater.WithoutCorrectData();


            string errorMessage = (new CostPage(webDriver).OpenPage() as CostPage)
                                    .FillInFields(UserCreater.IncorrectPhoneRegisteredUser())
                                    .Submit()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
        [Test]
        [Category("CostAviaTest")]
        public void WithoutDataCostTest()
        {
            Logger.Log.Info("Start ButtonCostTest unit test.");
            string expectingMessage = ErrorCreater.WithoutCorrectData();

            string errorMessage = (new CostPage(webDriver).OpenPage() as CostPage)
                                    .Submit()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);

        }
    }
}
