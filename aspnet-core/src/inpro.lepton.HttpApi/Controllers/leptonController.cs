using inpro.lepton.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace inpro.lepton.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class leptonController : AbpControllerBase
{
    protected leptonController()
    {
        LocalizationResource = typeof(leptonResource);
    }
}
