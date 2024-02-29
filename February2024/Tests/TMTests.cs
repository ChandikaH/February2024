using February2024.Pages;
using February2024.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace February2024.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TMTests : CommonDriver
    {

        [SetUp]
        public void SetUpTimeAndMaterial()
        {
            //Open Chrome/Firefox browser
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver, "hari", "123123");
            HomePage homePageObj = new HomePage();
            homePageObj.VerifyLoggedInUser(driver);
            homePageObj.NavigateToTMPage(driver);
        }

        [Test, Order(1), Description("This test create a new Time/Material record with valid details")]
        public void TestCreateTimeMaterialRecord()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            timeMaterialPageObj.CreateTimeMaterialRecord(driver);
        }

        [Test, Order(2), Description("This test edit the Time/Material record with valid data")]
        public void TestEditTimeMaterialRecord()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            timeMaterialPageObj.EditTimeMaterialRecord(driver);
        }

        [Test, Order(3), Description("This test delete the last Time/Material record")]
        public void TestDeleteTimeMaterialRecord()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            timeMaterialPageObj.DeleteTimeMaterialRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
