using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using SuperRocket.SinglePageApplication.EntityFramework;

namespace SuperRocket.SinglePageApplication.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<SinglePageApplicationDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}
