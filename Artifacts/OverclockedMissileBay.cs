using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.Midrow;

namespace VicCharacter.Artifacts;

public class VicOverclockedMissileBay : Artifact, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicOverclockedMissileBay", "name"]).Localize,
            Description = ModEntry.Instance.AnyLocalizations.Bind(["artifact", "VicOverclockedMissileBay", "desc"]).Localize,
            Sprite = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Artifact/OverclockedMissileBay.png")).Sprite
        });
    }

    public int VicOverclockedMissileBayCount = 0;

    public override int? GetDisplayNumber(State s)
    {
        return VicOverclockedMissileBayCount;
    }

    //public override List<Tooltip>? GetExtraTooltips()
    //{
    //    return new List<Tooltip>
    //    {
    //        new TTGlossary("midrow.missile_seeker")
    //    };
    //}

    public override void OnReceiveArtifact(State state)
    {
        state.ship.baseEnergy++;
    }

    public override void OnRemoveArtifact(State state)
    {
        state.ship.baseEnergy--;
    }

    public override List<Tooltip>? GetExtraTooltips()
    => [.. new VicDummySeeker().GetTooltips()];

    public override void OnTurnStart(State state, Combat combat)
    {
        VicOverclockedMissileBayCount++;
        if (VicOverclockedMissileBayCount >= 3)
        {
            VicOverclockedMissileBayCount = 0;
            combat.QueueImmediate(new ASpawn
            {
                artifactPulse = Key(),
                thing = new Missile
                {
                    yAnimation = 0.0,
                    missileType = MissileType.seeker,
                    targetPlayer = true
                }
            });
        };
    }

}