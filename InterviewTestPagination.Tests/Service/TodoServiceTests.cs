using InterviewTestPagination.Models.Todo;
using InterviewTestPagination.Models.Todo.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace InterviewTestPagination.Tests.Service
{
    public class TodoServiceTests
    {
        private MockRepository mockRepository;

        private Mock<ITodoService> mockTodoService;
        private Mock<ITodoRepository> mockTodoRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockTodoService = this.mockRepository.Create<ITodoService>();
            this.mockTodoRepository = this.mockRepository.Create<ITodoRepository>();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }

        private TodoService CreateService()
        {
            return new TodoService(
                this.mockTodoRepository.Object);
        }

        [TestMethod]
        public void ObterGerencia_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            mockTodoRepository.Setup(s => s.All()).Returns(Util.DataSourceTODO);
            var unitUnderTest = CreateService();

            // Act
            var result = unitUnderTest.All();

            // Assert
            Assert.IsTrue(result.Any());
        }
    }
}