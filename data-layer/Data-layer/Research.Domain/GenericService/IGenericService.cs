using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Research.Domain.GenericService
{
    public interface IGenericService<TEntity, TKey> where TEntity : class
    {
        TEntity GetById(TKey id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        void Delete(TKey id);

        void Delete(TEntity entityToDelete);

        HttpResponseMessage Insert(TEntity entity);

        void Update(TEntity entityToUpdate);
    }
}
