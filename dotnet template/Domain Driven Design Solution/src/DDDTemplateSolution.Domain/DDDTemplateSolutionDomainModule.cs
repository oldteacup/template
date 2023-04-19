using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;

namespace DDDTemplateSolution;

[DependsOn(
    typeof(DDDTemplateSolutionDomainSharedModule),
    typeof(AbpBackgroundJobsDomainModule),
    typeof(AbpFeatureManagementDomainModule)
)]
public class DDDTemplateSolutionDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //        Configure<AbpMultiTenancyOptions>(options =>
        //        {
        //            options.IsEnabled = MultiTenancyConsts.IsEnabled;
        //        });

    }
}
