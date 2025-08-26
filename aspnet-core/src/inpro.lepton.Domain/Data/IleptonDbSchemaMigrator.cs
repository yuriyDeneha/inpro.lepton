using System.Threading.Tasks;

namespace inpro.lepton.Data;

public interface IleptonDbSchemaMigrator
{
    Task MigrateAsync();
}
