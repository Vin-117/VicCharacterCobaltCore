using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.Midrow;

namespace VicCharacter.Artifacts;

public class VicRadioSystem : Artifact, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicRadioSystem", "name"]).Localize,
            //Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicAux", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicRadioSystem", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/RadioSystem.png")).Sprite
        });
    }
    public override void OnCombatStart(State state, Combat combat)
    {
        List<int> list = new List<int>();
        for (int i = state.ship.x - 1; i < state.ship.x + state.ship.parts.Count() + 1; i++)
        {
            if (!combat.stuff.ContainsKey(i))
            {
                list.Add(i);
            }
        }
        List<int> list2 = list.Shuffle(state.rngActions).Take(1).ToList();
        foreach (int item in list2)
        {
            combat.stuff.Add(item, new SignalAmplifier
            {
                targetPlayer = true,
                x = item,
                bubbleShield = true,
                xLerped = item
            });
        }
        if (list2.Count > 0)
        {
            Pulse();
        }
    }

    public override List<Tooltip>? GetExtraTooltips()
    => [.. new SignalAmplifier().GetTooltips(),
           new TTGlossary("midrow.bubbleShield")];

}