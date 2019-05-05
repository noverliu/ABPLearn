using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace PPG.Production.EntityFramework.Repositories
{
    public abstract class ProductionRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProductionDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProductionRepositoryBase(IDbContextProvider<ProductionDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProductionRepositoryBase<TEntity> : ProductionRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProductionRepositoryBase(IDbContextProvider<ProductionDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
