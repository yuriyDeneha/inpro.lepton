using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace inpro.lepton.Data;

/* This is used if database provider does't define
 * IleptonDbSchemaMigrator implementation.
 */
public class NullleptonDbSchemaMigrator : IleptonDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
