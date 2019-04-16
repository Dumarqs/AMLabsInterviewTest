using System.Collections.Generic;
using System.Linq;

namespace InterviewTestPagination.Utils
{
    /// <summary>
    /// Static method to return specific elements from IENumerable
    /// </summary>
    public static class PagingExtensions
    {
        /// <summary>
        /// Return the remaing elements
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">Source</param>
        /// <param name="page">Page number</param>
        /// <param name="pageSize">Size of the page</param>
        /// <returns>Return specific number of elements</returns>
        public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }

    }
}