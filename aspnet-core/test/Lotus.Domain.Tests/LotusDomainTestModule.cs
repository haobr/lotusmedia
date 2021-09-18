using Lotus.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lotus
{
    [DependsOn(
        typeof(LotusEntityFrameworkCoreTestModule)
        )]
    public class LotusDomainTestModule : AbpModule
    {

    }
}