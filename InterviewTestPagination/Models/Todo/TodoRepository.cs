using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using InterviewTestPagination.Models.Todo.Interfaces;
using InterviewTestPagination.Utils;

namespace InterviewTestPagination.Models.Todo {

    /// <summary>
    /// No need to use an actual persistent datasource. 
    /// All operations can be mocked in-memory as long as they are consistent with the chosen datasource implementation 
    /// (e.g. dont create new model instances when executing a search 'query', etc).
    /// TL;DR: from this point on Database-like operations can be mocked.
    /// </summary>
    public class TodoRepository : ModelRepository<Todo>, ITodoRepository {

        /// <summary>
        /// Example in-memory model datasource 'indexed' by id.
        /// </summary>
        private static readonly IDictionary<long, Todo> DataSource = new ConcurrentDictionary<long, Todo>();

        static TodoRepository() {
            // initializing datasource
            var startDate = DateTime.Today;
            for (var i = 1; i <= 55; i++) {
                var createdDate = startDate.AddDays(i);
                DataSource[i] = new Todo(id: i, task: "Dont forget to do " + i, createdDate: createdDate);
            }
        }

        /// <summary>
        /// Get all elements from DataSource
        /// </summary>
        /// <returns>Return an IENumerable containg all results</returns>
        public IEnumerable<Todo> All() {
            return DataSource.Values.OrderByDescending(t => t.CreatedDate);
        }

        /// <summary>
        /// Get elements by page from DataSource
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IEnumerable<Todo> ByPage(int page, int pageSize)
        {
            return DataSource.Values.Page(page, pageSize).OrderByDescending(t => t.CreatedDate);
        }

    }
}
