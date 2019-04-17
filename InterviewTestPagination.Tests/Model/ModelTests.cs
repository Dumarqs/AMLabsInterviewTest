using System;
using InterviewTestPagination.Models.Todo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewTestPagination.Tests.Model
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void Todo()
        {
            new Todo(1, "Dont forget to do 1", DateTime.Now);
        }
    }
}