using Microsoft.Extensions.Localization;
using inpro.lepton.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace inpro.lepton;

[Dependency(ReplaceServices = true)]
public class leptonBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<leptonResource> _localizer;

    public leptonBrandingProvider(IStringLocalizer<leptonResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
