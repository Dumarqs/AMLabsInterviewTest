using System.Collections.Generic;

namespace InterviewTestPagination.Models.Todo
{
    public interface ITodoService : IModelService<TodoService>
    {
        /// <summary>
        /// Get all result
        /// </summary>
        /// <returns></returns>
        IEnumerable<Todo> All();

        /// <summary>
        /// Get result by page
        /// </summary>
        /// <returns></returns>
        IEnumerable<Todo> ByPage(int page, int pageSize);
    }
}