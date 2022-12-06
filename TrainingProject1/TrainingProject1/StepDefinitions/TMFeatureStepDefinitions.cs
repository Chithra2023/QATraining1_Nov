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
        [When(@"I update '([^']*)' of an existing Time & Material record")]
        public void WhenIUpdateOfAnExistingTimeMaterialRecord(string Description)
        {
        
            TMPage tmPageobj = new TMPage();
            tmPageobj.EditTM(driver, Description);
        }

        [Then(@"The record should have an updated '([^']*)'")]
        public void ThenTheRecordShouldHaveAnUpdated(string Description)
        {
            TMPage tmPageobj = new TMPage();
            string editDescription = tmPageobj.GetEditedDescription(driver);
            Assert.That(editDescription == Description, "Actual description and Expected description not matching");
        }

    }
}
