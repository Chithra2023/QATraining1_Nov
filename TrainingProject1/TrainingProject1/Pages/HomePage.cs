
namespace TrainingProject1.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // navigate to time and material
            Thread.Sleep(3000);
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            // navigate to time and material
            Thread.Sleep(2000);
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click(); 

        }
    }
}
