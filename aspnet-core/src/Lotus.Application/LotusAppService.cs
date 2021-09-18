using System;
using System.Collections.Generic;
using System.Text;
using Lotus.Localization;
using Volo.Abp.Application.Services;

namespace Lotus
{
    /* Inherit your application services from this class.
     */
    public abstract class LotusAppService : ApplicationService
    {
        protected LotusAppService()
        {
            LocalizationResource = typeof(LotusResource);
        }
    }
}
