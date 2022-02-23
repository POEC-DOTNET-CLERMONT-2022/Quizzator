using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quizzator.API_REST.Controllers;
using Quizzator.Persistance;

namespace Tests
{
    [TestClass]
    public class ApiTest
    {
        private readonly ThemeController _themeController;
        private IMapper mapper;

        public ApiTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Test; Trusted_Connection=True",
                builder => builder.EnableRetryOnFailure());
            var context = new QuizContext(optionsBuilder.Options);
            _themeController = new ThemeController(new ThemeManager(context), mapper);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}