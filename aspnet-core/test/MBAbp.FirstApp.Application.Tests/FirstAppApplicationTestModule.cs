using Volo.Abp.Modularity;

namespace MBAbp.FirstApp;

[DependsOn(
    typeof(FirstAppApplicationModule),
    typeof(FirstAppDomainTestModule)
    )]
public class FirstAppApplicationTestModule : AbpModule
{

}
