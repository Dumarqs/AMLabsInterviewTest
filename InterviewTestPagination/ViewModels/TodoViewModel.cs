using InterviewTestPagination.Models.Todo;
using System.Collections.Generic;

namespace InterviewTestPagination.ViewModels
{
    public class TodoViewModel
    {
        public IEnumerable<Todo> Todos { get; set; }
        public int Count { get; set; }
    }
}