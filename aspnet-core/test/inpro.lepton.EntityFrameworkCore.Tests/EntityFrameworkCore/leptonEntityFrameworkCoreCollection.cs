using Xunit;

namespace inpro.lepton.EntityFrameworkCore;

[CollectionDefinition(leptonTestConsts.CollectionDefinitionName)]
public class leptonEntityFrameworkCoreCollection : ICollectionFixture<leptonEntityFrameworkCoreFixture>
{

}
