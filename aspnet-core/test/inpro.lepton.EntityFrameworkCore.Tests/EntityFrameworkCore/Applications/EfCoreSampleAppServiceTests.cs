using inpro.lepton.Samples;
using Xunit;

namespace inpro.lepton.EntityFrameworkCore.Applications;

[Collection(leptonTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<leptonEntityFrameworkCoreTestModule>
{

}
