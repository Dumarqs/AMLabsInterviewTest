using InterviewTestPagination.Models.Todo;
using System.Collections.Generic;
using System.Web.Http;
using InterviewTestPagination.ViewModels;

namespace InterviewTestPagination.Controllers
{
    /// <summary>
    /// 'Rest' controller for the <see cref="Todo"/>
    /// </summary>
    public class TodoController : ApiController
    {
        /// <summary>
        /// Create instace of Interface ITodoService
        /// </summary>
        private ITodoService _todoService;

        /// <summary>
        /// Constructor Method of Todo
        /// </summary>
        /// <param name="todoService"></param>
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public TodoViewModel All() {
            return _todoService.All();
        }

        [HttpGet]
        public TodoViewModel ByPage(int page, int pageSize)
        {
            return _todoService.ByPage(page, pageSize);
        }

    }
}
