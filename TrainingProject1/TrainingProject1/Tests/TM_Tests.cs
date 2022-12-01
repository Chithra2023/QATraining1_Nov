using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject1.Pages;
using NUnit.Framework;
using TrainingProject1.Utilities;

namespace TrainingProject1.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            // login page object initialization and definition
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);


            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
        }

        [Test]
        public void EditTM_Test()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.EditTM(driver);
        }

        [Test]
        public void DeleteTM_Test()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
                    }

        
        
        
        // Open the browser
        




      

    

       
    }
}
