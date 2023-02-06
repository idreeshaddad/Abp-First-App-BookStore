using Volo.Abp.Settings;

namespace MBAbp.FirstApp.Settings;

public class FirstAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FirstAppSettings.MySetting1));
    }
}
