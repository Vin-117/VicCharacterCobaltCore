using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.Midrow;
using VicCharacter.Features;
using VicCharacter.Cards;

namespace VicCharacter.Artifacts;

public class VicSalvoUpgrade : Artifact, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Artifacts.RegisterArtifact(new ArtifactConfiguration
        {
            ArtifactType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new ArtifactMeta
            {
                pools = [ArtifactPool.Boss],
                owner = ModEntry.Instance.VicCharacter.Deck,
                unremovable = true
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicSalvoUpgrade", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicSalvoUpgrade", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/SalvoUpgrade.png")).Sprite
        });
    }

    public override void OnReceiveArtifact(State state)
    {
        state.GetCurrentQueue().QueueImmediate(new ARemoveCard());
        state.GetCurrentQueue().Queue(new ASpecificCardOffering
        {
            Destination = CardDestination.Deck,
            CanSkip = false,
            Cards = [
                        new VicHeavySalvo{ },
                    ],
        });
    }

    public override List<Tooltip>? GetExtraTooltips()
    {
        return new List<Tooltip>
        {
            new TTCard
            {
                card = new VicHeavySalvo()
                {
                    upgrade = Upgrade.None
                }
            }
        };
    }

}