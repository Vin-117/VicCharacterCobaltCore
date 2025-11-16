using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.Midrow;
using VicCharacter.Cards;

namespace VicCharacter.Artifacts;

public class VicRegenExhaust : Artifact, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicRegenExhaust", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicRegenExhaust", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/RegenExhaust.png")).Sprite
        });
    }

    public override List<Tooltip>? GetExtraTooltips()
    {
        return new List<Tooltip>
        {
            new TTCard
            {
                card = new VicDrift()
                {
                    upgrade = Upgrade.None
                }
            }
        };
    }

    public override void OnCombatStart(State state, Combat combat)
    {
        combat.QueueImmediate(new AAddCard
        {
            card = new VicDrift() 
            {
                upgrade = Upgrade.A
            },
            destination = CardDestination.Hand,
            amount = 1
        });
    }
}