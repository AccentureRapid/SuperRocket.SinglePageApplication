using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SuperRocket.SinglePageApplication.EntityFramework;

namespace SuperRocket.SinglePageApplication.Migrator
{
    [DependsOn(typeof(SinglePageApplicationDataModule))]
    public class SinglePageApplicationMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SinglePageApplicationDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}