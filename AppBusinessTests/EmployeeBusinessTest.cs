using AppBusiness;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppBusinessTests
{
    [TestClass]
    public class EmployeeBusinessTest
    {
        [TestMethod]
        public void GetEmployeeCode_should_return_1_as_new_employee_code()
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();

            Assert.AreEqual(1, employeeBusiness.GetEmployeeCode(), "Employee code is not equal to 1.");
        }
    }
}
