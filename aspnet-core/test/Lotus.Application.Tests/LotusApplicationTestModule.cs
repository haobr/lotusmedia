using Volo.Abp.Modularity;

namespace Lotus
{
    [DependsOn(
        typeof(LotusApplicationModule),
        typeof(LotusDomainTestModule)
        )]
    public class LotusApplicationTestModule : AbpModule
    {

    }
}