using System.Threading.Tasks;

namespace DDDTemplateSolution.Data;

public interface IDDDTemplateSolutionDbSchemaMigrator
{
    Task MigrateAsync();
}
