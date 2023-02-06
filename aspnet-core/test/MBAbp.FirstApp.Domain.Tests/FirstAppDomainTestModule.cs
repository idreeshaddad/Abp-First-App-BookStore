using MBAbp.FirstApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MBAbp.FirstApp;

[DependsOn(
    typeof(FirstAppEntityFrameworkCoreTestModule)
    )]
public class FirstAppDomainTestModule : AbpModule
{

}
