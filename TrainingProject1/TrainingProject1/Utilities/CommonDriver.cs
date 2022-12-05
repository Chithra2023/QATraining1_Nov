
namespace TrainingProject1.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            // login page object initialization and definition
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
