using System.Collections.Generic;
using InterviewTestPagination.ViewModels;

namespace InterviewTestPagination.Models.Todo.Interfaces
{
    public interface ITodoRepository : IModelRepository<Todo>
    {
        /// <summary>
        /// lists all entries of type T
        /// </summary>
        /// <returns></returns>
        TodoViewModel All();

        /// <summary>
        /// Method that get a list by page of type T
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        TodoViewModel ByPage(int page, int pageSize);
    }
}