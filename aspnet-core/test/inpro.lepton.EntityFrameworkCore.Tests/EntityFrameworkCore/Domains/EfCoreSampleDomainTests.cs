using inpro.lepton.Samples;
using Xunit;

namespace inpro.lepton.EntityFrameworkCore.Domains;

[Collection(leptonTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<leptonEntityFrameworkCoreTestModule>
{

}
