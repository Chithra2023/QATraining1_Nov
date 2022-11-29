using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject1.Pages
{
    public class TMPage
    {

        public void CreateTM(IWebDriver driver)
        {
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

        }

        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findNewRecordCreated = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findNewRecordCreated.Text == "CNTestNov2022")
            {
                Thread.Sleep(2000);
                // click edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
               Console.WriteLine ("Record to be edited hasn't been found. Record not edited");
            }
            // edit code textbox 
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("CNTestNov2022_01");
            Thread.Sleep(1500);

            // edit description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("CNTestNov2022_01");
            Thread.Sleep(1500);

            // edit price per unit textbox
            //IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            //IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));

            //overlappingTag.Click();
            //pricePerUnitTextbox.Clear();
            //overlappingTag.Click();
            //pricePerUnitTextbox.SendKeys("200");
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            
            overlappingTag.Click();
                        
            priceTextBox.Clear();
            overlappingTag.Click();
            priceTextBox.SendKeys("20");

            // click save button
            IWebElement clickSavebutton = driver.FindElement(By.Id("SaveButton"));
            clickSavebutton.Click();
            Thread.Sleep(1500);

            // click go to the last page
            IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpageButton.Click();
            Thread.Sleep(1500);


        }

        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            // click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);

            // conforming delete ok button
            driver.SwitchTo().Alert().Accept();
        }
    }
}
