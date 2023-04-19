using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DDDTemplateSolution.Data;

/* This is used if database provider does't define
 * IDDDTemplateSolutionDbSchemaMigrator implementation.
 */
public class NullDDDTemplateSolutionDbSchemaMigrator : IDDDTemplateSolutionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
