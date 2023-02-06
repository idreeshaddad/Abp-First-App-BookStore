using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MBAbp.FirstApp;

[Dependency(ReplaceServices = true)]
public class FirstAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FirstApp";
}
