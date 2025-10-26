using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.Midrow;

namespace VicCharacter.Artifacts;

public class VicSidelink : Artifact, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Artifacts.RegisterArtifact(new ArtifactConfiguration
        {
            ArtifactType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new ArtifactMeta
            {
                pools = [ArtifactPool.Common],
                owner = ModEntry.Instance.VicCharacter.Deck
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicSidelink", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicSidelink", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/Sidelink.png")).Sprite
        });
    }

    public int VicSidelinkCount = 0;

    public override int? GetDisplayNumber(State s)
    {
        return VicSidelinkCount;
    }

    public override void OnPlayerSpawnSomething(State state, Combat combat, StuffBase thing)
    {
        VicSidelinkCount++;
        if (VicSidelinkCount >= 3)
        {
            VicSidelinkCount = 0;
            combat.QueueImmediate(new AStatus
            {
                targetPlayer = true,
                status = Status.evade,
                statusAmount = 1,
                artifactPulse = Key(),
                //dialogueSelector = ".CrosslinkTrigger"
            });
        }
    }


}