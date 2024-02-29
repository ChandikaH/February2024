using OpenQA.Selenium;

namespace February2024.Pages
{
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Created");
        }

        public void EditEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Edited");
        }

        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("Employee Record Deleted");
        }

    }
}
