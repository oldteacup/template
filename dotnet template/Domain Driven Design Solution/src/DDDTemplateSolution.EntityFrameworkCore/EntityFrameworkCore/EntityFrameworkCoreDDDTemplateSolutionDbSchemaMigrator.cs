using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DDDTemplateSolution.Data;
using Volo.Abp.DependencyInjection;

namespace DDDTemplateSolution.EntityFrameworkCore;

public class EntityFrameworkCoreDDDTemplateSolutionDbSchemaMigrator
    : IDDDTemplateSolutionDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDDDTemplateSolutionDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DDDTemplateSolutionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DDDTemplateSolutionDbContext>()
            .Database
            .MigrateAsync();
    }
}
