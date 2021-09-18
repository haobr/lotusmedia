using Lotus.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Lotus.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LotusEntityFrameworkCoreModule),
        typeof(LotusApplicationContractsModule)
        )]
    public class LotusDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
