using System.Collections.Generic;

namespace InterviewTestPagination.Models.Todo.Interfaces
{
    public interface ITodoRepository : IModelRepository<Todo>
    {
        /// <summary>
        /// lists all entries of type T
        /// </summary>
        /// <returns></returns>
        IEnumerable<Todo> All();

        /// <summary>
        /// Method that get a list by page of type T
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IEnumerable<Todo> ByPage(int page, int pageSize);
    }
}