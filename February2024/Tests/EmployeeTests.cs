using February2024.Pages;
using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace February2024.Tests
{
    [Parallelizable]
    [TestFixture]
    public class EmployeeTests : CommonDriver
    {

        [SetUp]
        public void SetUp()
        {
            //Open Chrome/Firefox browser
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver, "hari", "123123");
            HomePage homePageObj = new HomePage();
            homePageObj.VerifyLoggedInUser(driver);
            homePageObj.NavigateToEmployeePage(driver);
        }

        [Test, Order(1), Description("This test create a new Employee record with valid details")]
        public void TestCreateEmployeeRecord()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployeeRecord(driver);
        }

        [Test, Order(2), Description("This test edit the Employee record with valid data")]
        public void TestEditEmployeeRecord()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployeeRecord(driver);
        }

        [Test, Order(3), Description("This test delete the last Employee record")]
        public void TestDeleteEmployeeRecord()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployeeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
