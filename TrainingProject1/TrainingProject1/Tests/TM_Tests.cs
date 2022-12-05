
namespace TrainingProject1.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {

        [Test, Order(1), Description("Check if user is able to create a new record")]
        public void CreateTM_Test()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
        }

        [Test, Order(2), Description(" Check if user is able to edit an existing record")]
        public void EditTM_Test()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);

            TMPage tmPageobj = new TMPage();
            tmPageobj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user can delete a record")]
        public void DeleteTM_Test()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);

            TMPage tmPageobj = new TMPage();
            tmPageobj.DeleteTM(driver);
        }
           
    }
}
