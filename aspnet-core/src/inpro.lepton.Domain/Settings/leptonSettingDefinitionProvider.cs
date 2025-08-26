using Volo.Abp.Settings;

namespace inpro.lepton.Settings;

public class leptonSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(leptonSettings.MySetting1));
    }
}
