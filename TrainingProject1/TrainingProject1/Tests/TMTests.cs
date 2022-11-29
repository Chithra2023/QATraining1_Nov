

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Media;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using TrainingProject1.Pages;


// Open the browser
IWebDriver driver = new ChromeDriver();

// login page object initialization and definition
LoginPage loginpageobj = new LoginPage();
loginpageobj.LoginActions(driver);


// Home page object initialization and definition
HomePage homepageobj = new HomePage();
homepageobj.GoToTMPage(driver);


// TM page object initialization and definition
TMPage tmPageobj = new TMPage();
tmPageobj.CreateTM(driver);

tmPageobj.EditTM(driver);

tmPageobj.DeleteTM(driver);








