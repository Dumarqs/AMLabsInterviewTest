using InterviewTestPagination.Models.Todo;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace InterviewTestPagination.Tests
{
    public static class Util
    {
        public static IEnumerable<Todo> DataSourceTODO()
        {
            IDictionary<long, Todo> DataSource = new ConcurrentDictionary<long, Todo>();

            // initializing datasource
            var startDate = DateTime.Today;
            for (var i = 1; i <= 55; i++)
            {
                var createdDate = startDate.AddDays(i);
                DataSource[i] = new Todo(id: i, task: "Dont forget to do " + i, createdDate: createdDate);
            }

            return DataSource.Values;
        }
    }
}