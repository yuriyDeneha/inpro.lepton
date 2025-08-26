using Volo.Abp.Modularity;

namespace inpro.lepton;

public abstract class leptonApplicationTestBase<TStartupModule> : leptonTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
