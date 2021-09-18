using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Lotus.Data
{
    /* This is used if database provider does't define
     * ILotusDbSchemaMigrator implementation.
     */
    public class NullLotusDbSchemaMigrator : ILotusDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}