using Volo.Abp.Settings;

namespace Symphony.Ltd.Settings;

public class LtdSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LtdSettings.MySetting1));
    }
}
