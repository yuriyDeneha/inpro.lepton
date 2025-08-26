using System;
using System.Collections.Generic;
using System.Text;
using inpro.lepton.Localization;
using Volo.Abp.Application.Services;

namespace inpro.lepton;

/* Inherit your application services from this class.
 */
public abstract class leptonAppService : ApplicationService
{
    protected leptonAppService()
    {
        LocalizationResource = typeof(leptonResource);
    }
}
