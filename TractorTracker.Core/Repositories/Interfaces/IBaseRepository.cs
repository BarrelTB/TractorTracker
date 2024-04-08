using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorTracker.Core.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);

    }
}
