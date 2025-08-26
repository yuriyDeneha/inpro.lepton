using Volo.Abp.Modularity;

namespace inpro.lepton;

[DependsOn(
    typeof(leptonDomainModule),
    typeof(leptonTestBaseModule)
)]
public class leptonDomainTestModule : AbpModule
{

}
