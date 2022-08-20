using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_FinalExam_Net6.Controllers;
using ASP_FinalExam_Net6.Data;
using ASP_FinalExam_Net6.Models;

namespace ASP_FinalExam_Net6.Tests
{
    public class InMemoryTest
    {
        protected readonly DbContextOptions<ApplicationDbContext> _opts;

        // generates connection
        public InMemoryTest()
        {
            _opts = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "Exam").Options;
        }
    }
}
