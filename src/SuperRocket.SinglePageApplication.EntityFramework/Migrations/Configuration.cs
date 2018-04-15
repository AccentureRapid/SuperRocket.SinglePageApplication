using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using SuperRocket.SinglePageApplication.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace SuperRocket.SinglePageApplication.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SinglePageApplication.EntityFramework.SinglePageApplicationDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SinglePageApplication";
        }

        protected override void Seed(SinglePageApplication.EntityFramework.SinglePageApplicationDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
