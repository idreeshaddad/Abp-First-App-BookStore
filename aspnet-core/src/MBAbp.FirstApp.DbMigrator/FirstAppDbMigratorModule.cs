using MBAbp.FirstApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MBAbp.FirstApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FirstAppEntityFrameworkCoreModule),
    typeof(FirstAppApplicationContractsModule)
    )]
public class FirstAppDbMigratorModule : AbpModule
{

}
