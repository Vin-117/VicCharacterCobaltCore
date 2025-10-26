using FMOD;
using JetBrains.Annotations;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.Midrow;

namespace VicCharacter.Artifacts;

public class VicLevelheaded : Artifact, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Artifacts.RegisterArtifact(new ArtifactConfiguration
        {
            ArtifactType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new ArtifactMeta
            {
                pools = [ArtifactPool.Boss],
                owner = ModEntry.Instance.VicCharacter.Deck
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicLevelheaded", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicLevelheaded", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/Levelheaded.png")).Sprite
        });
    }

    public int LevelheadedCount = 0;

    public override int? GetDisplayNumber(State s)
    {
        return LevelheadedCount;
    }

    public override void OnPlayerPlayCard(int energyCost, Deck deck, Card card, State state, Combat combat, int handPosition, int handCount)
    {

        if ((card.GetDataWithOverrides(state).temporary) && LevelheadedCount <= 1)
        {
            LevelheadedCount++;
            Pulse();
            combat.QueueImmediate(new ADrawCard
            {
                count = 1
            });
        }
    }

    public override void OnTurnEnd(State state, Combat combat)
    {
        LevelheadedCount = 0;
    }

    public override void OnCombatEnd(State state)
    {
        LevelheadedCount = 0;
    }


}