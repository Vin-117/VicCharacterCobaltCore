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

    private static Spr UsedUpSpr;

    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {

        UsedUpSpr = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/LevelheadedUsed.png")).Sprite;

        helper.Content.Artifacts.RegisterArtifact(new ArtifactConfiguration
        {
            ArtifactType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new ArtifactMeta
            {
                pools = [ArtifactPool.Boss],
                owner = ModEntry.Instance.VicCharacter.Deck,
                unremovable = true
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicLevelheaded", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicLevelheaded", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/Levelheaded.png")).Sprite
        });
    }

    public bool LevelheadedUsed = false;

    public override void OnPlayerPlayCard(int energyCost, Deck deck, Card card, State state, Combat combat, int handPosition, int handCount)
    {

        if ((card.GetDataWithOverrides(state).temporary) && (!LevelheadedUsed))
        {
            LevelheadedUsed = true;
            Pulse();
            combat.QueueImmediate(new AEnergy
            {
                changeAmount = 1
            });
        }
    }

    public override void OnTurnStart(State state, Combat combat)
    {
        LevelheadedUsed = false;
    }

    public override void OnCombatEnd(State state)
    {
        LevelheadedUsed = false;
    }

    public override Spr GetSprite()
    {
        if (LevelheadedUsed)
        {
            return UsedUpSpr;
        }
        else
        {
            return base.GetSprite();
        }
    }


}