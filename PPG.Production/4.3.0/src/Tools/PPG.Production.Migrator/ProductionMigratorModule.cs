using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using PPG.Production.EntityFramework;

namespace PPG.Production.Migrator
{
    [DependsOn(typeof(ProductionDataModule))]
    public class ProductionMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ProductionDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}