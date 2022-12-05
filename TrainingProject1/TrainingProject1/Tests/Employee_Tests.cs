
namespace TrainingProject1.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {

        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToEmployeePage(driver);

            EmployeePage employeePageobj = new EmployeePage();
            employeePageobj.CreateEmployee(driver);
        }
        [Test, Order(2)]
        public void EditEmploee_Test()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToEmployeePage(driver);

            EmployeePage employeePageobj = new EmployeePage();
            employeePageobj.EditEmployee(driver);
        }
       
        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            // Home page object initialization and definition
            HomePage homepageobj = new HomePage();
            homepageobj.GoToEmployeePage(driver);

            EmployeePage employeePageobj = new EmployeePage();
            employeePageobj.DeleteEmployee(driver);
        }

   }
}
