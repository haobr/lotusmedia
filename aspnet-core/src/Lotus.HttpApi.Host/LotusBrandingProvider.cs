using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Lotus
{
    [Dependency(ReplaceServices = true)]
    public class LotusBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Lotus";
    }
}
