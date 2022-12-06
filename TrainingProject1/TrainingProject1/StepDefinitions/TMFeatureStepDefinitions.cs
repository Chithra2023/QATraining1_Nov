using System;
using TechTalk.SpecFlow;

namespace TrainingProject1.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged in to turnup portal sucessfully")]
        public void GivenILoggedInToTurnupPortalSucessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);
        }

        [When(@"I create a new Time and Material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
        }

        [Then(@"The record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {
            TMPage tmPageobj = new TMPage();

            string newCode = tmPageobj.GetCode(driver);
            string newDescription = tmPageobj.GetDescription(driver);
            string newPrice = tmPageobj.GetPrice(driver);


            Assert.That(newCode == "CNTestNov2022", "Actual Code and Expected Code do not match");
            Assert.That(newDescription == "CNTestNov2022", "Actual Description  and Expected Description do not match");
            Assert.That(newPrice == "$15.00", "Actual Description  and Expected Description do not match");
        }
        //[When(@"I update '([^']*)' of an existing Time & Material record")]
        //public void WhenIUpdateOfAnExistingTimeMaterialRecord(string Description)
        //{
        
        //    TMPage tmPageobj = new TMPage();
        //    tmPageobj.EditTM(driver, Description);
        //}

        //[Then(@"The record should have an updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveAnUpdated(string Description)
        //{
        //    TMPage tmPageobj = new TMPage();
        //    string editDescription = tmPageobj.GetEditedDescription(driver);
        //    Assert.That(editDescription == Description, "Actual description and Expected description not matching");
        //}

        [When(@"I update '([^']*)',CN(.*), (.*) of an existing Time & Material record")]
        public void WhenIUpdateCNOfAnExistingTimeMaterialRecord(string description, string code, string price)
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.EditTM(driver, description, code, price);
        }

        [Then(@"The record should have an updated '([^']*)', CN(.*) and (.*)")]
        public void ThenTheRecordShouldHaveAnUpdatedCNAnd(string description, string code, string price)
        {
            TMPage tmPageobj = new TMPage();
            string editedDescription = tmPageobj.GetEditedDescription(driver);
            string editedCode= tmPageobj.GetEditedCode(driver);
            string editedPrice = tmPageobj.GetEditedPrice(driver);

            Assert.That(editedDescription == description, "Actual description and Expected description do not match");
            Assert.That(editedCode == code, "Actual code and Expected code do not match");
            Assert.That(editedPrice == price, "Actual price and Expected price do not match");

        }


    }
}
