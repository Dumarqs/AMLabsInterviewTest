using System.Linq;
using InterviewTestPagination.Models.Todo.Interfaces;
using InterviewTestPagination.ViewModels;

namespace InterviewTestPagination.Models.Todo
{
    /// <summary>
    /// TODO: Implement methods that enable pagination
    /// </summary>
    public class TodoService : ITodoService
    {

        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository todoService)
        {
            _repository = todoService;
        }

        /// <summary>
        /// Get all 
        /// </summary>
        /// <returns></returns>
        public TodoViewModel All() {
            return _repository.All();
        }

        /// <summary>
        /// Get by page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public TodoViewModel ByPage(int page, int pageSize)
        {
            return _repository.ByPage(page, pageSize); 
        }
    }
}
