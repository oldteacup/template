using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace DDDTemplateSolution;

[DependsOn(
    typeof(DDDTemplateSolutionDomainSharedModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class DDDTemplateSolutionApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        DDDTemplateSolutionDtoExtensions.Configure();
    }
}
