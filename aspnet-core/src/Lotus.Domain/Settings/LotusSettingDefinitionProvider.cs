using Volo.Abp.Settings;

namespace Lotus.Settings
{
    public class LotusSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LotusSettings.MySetting1));
        }
    }
}
