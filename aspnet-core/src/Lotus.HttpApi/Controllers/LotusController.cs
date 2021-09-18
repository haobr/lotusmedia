using Lotus.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lotus.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LotusController : AbpController
    {
        protected LotusController()
        {
            LocalizationResource = typeof(LotusResource);
        }
    }
}