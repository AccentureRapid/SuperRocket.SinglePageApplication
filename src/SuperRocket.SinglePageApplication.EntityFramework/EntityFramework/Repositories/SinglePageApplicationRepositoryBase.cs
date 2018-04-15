using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SuperRocket.SinglePageApplication.EntityFramework.Repositories
{
    public abstract class SinglePageApplicationRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SinglePageApplicationDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SinglePageApplicationRepositoryBase(IDbContextProvider<SinglePageApplicationDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SinglePageApplicationRepositoryBase<TEntity> : SinglePageApplicationRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SinglePageApplicationRepositoryBase(IDbContextProvider<SinglePageApplicationDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
