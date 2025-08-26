using Volo.Abp.Modularity;

namespace inpro.lepton;

[DependsOn(
    typeof(leptonApplicationModule),
    typeof(leptonDomainTestModule)
)]
public class leptonApplicationTestModule : AbpModule
{

}
