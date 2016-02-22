using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var controller = new EmployeeController();
            var result = controller.GetEmployees() as Employee.Models.Employee;
           // var result = emp.GetEmployees();
            Assert.IsNotNull(result);
        }
    }
}
