using Volo.Abp.Modularity;

namespace inpro.lepton;

/* Inherit from this class for your domain layer tests. */
public abstract class leptonDomainTestBase<TStartupModule> : leptonTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
