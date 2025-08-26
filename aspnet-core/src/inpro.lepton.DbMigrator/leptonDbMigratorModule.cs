using inpro.lepton.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace inpro.lepton.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(leptonEntityFrameworkCoreModule),
    typeof(leptonApplicationContractsModule)
    )]
public class leptonDbMigratorModule : AbpModule
{
}
