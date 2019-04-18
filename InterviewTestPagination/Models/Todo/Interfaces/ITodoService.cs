using System.Collections.Generic;
using InterviewTestPagination.ViewModels;

namespace InterviewTestPagination.Models.Todo
{
    public interface ITodoService : IModelService<TodoService>
    {
        /// <summary>
        /// Get all result
        /// </summary>
        /// <returns></returns>
        TodoViewModel All();

        /// <summary>
        /// Get result by page
        /// </summary>
        /// <returns></returns>
        TodoViewModel ByPage(int page, int pageSize);
    }
}