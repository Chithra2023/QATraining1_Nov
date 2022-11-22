

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Media;


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



