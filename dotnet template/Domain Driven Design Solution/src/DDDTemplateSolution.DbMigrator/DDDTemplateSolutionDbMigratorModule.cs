using DDDTemplateSolution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DDDTemplateSolution.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DDDTemplateSolutionEntityFrameworkCoreModule),
    typeof(DDDTemplateSolutionApplicationContractsModule)
    )]
public class DDDTemplateSolutionDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
