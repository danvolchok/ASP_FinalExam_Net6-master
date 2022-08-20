using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_FinalExam_Net6.Controllers;
using ASP_FinalExam_Net6.Data;
using ASP_FinalExam_Net6.Models;

namespace ASP_FinalExam_Net6.Tests
{
    public class EmployeesControllerTest : InMemoryTest
    {
        [Fact]
        public async Task Index_Returns_ViewResult_And_EmployeeList()
        {
            // disposes this test db after use
            using (var testDb = new ApplicationDbContext(this._opts))
            {
                var testCtrl = new EmployeesController(testDb);
                var result = await testCtrl.Index();
                var resVr = Assert.IsType<ViewResult>(result);
                Assert.IsAssignableFrom<IEnumerable<Employee>>(resVr.ViewData.Model);
            }
        }
    }
}
