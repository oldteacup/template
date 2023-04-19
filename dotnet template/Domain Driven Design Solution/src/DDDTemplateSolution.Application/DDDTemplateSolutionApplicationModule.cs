using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace DDDTemplateSolution;

[DependsOn(
    typeof(DDDTemplateSolutionDomainModule),
    typeof(DDDTemplateSolutionApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationModule)
    )]
public class DDDTemplateSolutionApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<DDDTemplateSolutionApplicationModule>();
        });
    }
}
