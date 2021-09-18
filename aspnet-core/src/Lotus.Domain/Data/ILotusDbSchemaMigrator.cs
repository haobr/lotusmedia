using System.Threading.Tasks;

namespace Lotus.Data
{
    public interface ILotusDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
