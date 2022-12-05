
namespace TrainingProject1.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            // login page object initialization and definition
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
