using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter;

internal interface IRegisterable
{
    static abstract void Register(IPluginPackage<IModManifest> package, IModHelper helper);
}