

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Media;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;


// Open the browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// Identify the user name text box and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// Identify the user name text box and enter valid username
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// Click login Button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// Check if user has logged in sucessfully
IWebElement helloHariLabel = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
if (helloHariLabel.Text == "Hello hari!")

{
    Console.Write("Logged in sucessully, test passed.");
}

else 
{
    Console.WriteLine("Login failed, test failed");
      
}

// navigate to time and material

IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();
Thread.Sleep(500);

IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();


// Click on "Create New" button
Thread.Sleep(1500);
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewButton.Click();


// Select "Time" in the "TypeCode" drop down
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
typeCodeDropdown.Click();
Thread.Sleep(500);

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
timeOption.Click();
Thread.Sleep(500);

// enter code in the 'code' textbox
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("CNTestNov2022");

// enter description in the "Description" textbox
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.SendKeys("CNTestNov2022");

// enter price in "Price per unit" textbox
IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
overlappingTag.Click();

IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
priceTextBox.SendKeys("15");

// click on "Save" button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);

// check that new Time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goToLastPageButton.Click();
Thread.Sleep(1000);

IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

//IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "CNTestNov2022")
{
    Console.WriteLine("Time record created successfully.");
}
else
{
    Console.WriteLine("Time record hasn't been created successfully");
}









