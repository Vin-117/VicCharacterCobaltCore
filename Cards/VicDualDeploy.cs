using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicDualDeploy : Card, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Cards.RegisterCard(new CardConfiguration
        {
            CardType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new CardMeta
            {
                deck = ModEntry.Instance.VicCharacter.Deck,
                rarity = Rarity.uncommon,
                dontOffer = false,
                upgradesTo = [Upgrade.A, Upgrade.B]
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicDualDeploy", "name"]).Localize,
        });
    }

    public override CardData GetData(State state)
        => new()
        {
            art = flipped ? StableSpr.cards_Adaptability_Bottom : StableSpr.cards_Adaptability_Top,
            cost = 1,
            floppable = true,
            retain = upgrade == Upgrade.B ? true : false,
        };

    public override List<CardAction> GetActions(State s, Combat c)
    {
        switch (this.upgrade)
        {
            case Upgrade.None:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                               yAnimation = 0.0
                            },
                            disabled = flipped
                        },
                        new ADummyAction(),
                        new ASpawn
                        {
                            thing = new Missile
                            {
                               yAnimation = 0.0,
                               missileType = MissileType.heavy
                            },
                            disabled = !flipped
                        },
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.droneShift,
                            statusAmount = 1,
                            targetPlayer = true,
                            disabled = flipped
                        },
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                               yAnimation = 0.0
                            },
                            disabled = flipped
                        },
                        new ADummyAction(),
                        new ADrawCard
                        {
                            count = 1,
                            disabled = !flipped
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                               yAnimation = 0.0,
                               missileType = MissileType.heavy
                            },
                            disabled = !flipped
                        },
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                               yAnimation = 0.0
                            },
                            disabled = flipped
                        },
                        new ADummyAction(),
                        new ASpawn
                        {
                            thing = new Missile
                            {
                               yAnimation = 0.0,
                               missileType = MissileType.heavy
                            },
                            disabled = !flipped
                        },
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                               yAnimation = 0.0
                            },
                            disabled = flipped
                        },
                        new ADummyAction(),
                        new ASpawn
                        {
                            thing = new Missile
                            {
                               yAnimation = 0.0,
                               missileType = MissileType.heavy
                            },
                            disabled = !flipped
                        },
                    };
                }
        }
    }
}