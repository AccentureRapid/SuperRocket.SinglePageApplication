using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SuperRocket.SinglePageApplication.EntityFramework;

namespace SuperRocket.SinglePageApplication
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SinglePageApplicationCoreModule))]
    public class SinglePageApplicationDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SinglePageApplicationDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
