using System;
using System.Collections.Generic;

namespace InterviewTestPagination.Models
{
    public class ModelRepository<TEntity> : IModelRepository<TEntity>, IDisposable
        where TEntity : class
    {
        #region Dispose

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}