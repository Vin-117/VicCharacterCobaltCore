using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicMobileMine : Card, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Cards.RegisterCard(new CardConfiguration
        {
            CardType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new CardMeta
            {
                deck = ModEntry.Instance.VicCharacter.Deck,
                rarity = Rarity.common,
                dontOffer = false,
                upgradesTo = [Upgrade.A, Upgrade.B]
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicMobileMine", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicMeteor.png")).Sprite,
        });
    }

    public override CardData GetData(State state)
    {
        return new CardData
        {
            cost = 2
        };
    }

    public override List<CardAction> GetActions(State s, Combat c)
    {
        switch (this.upgrade)
        {
            case Upgrade.None:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.droneShift,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                                yAnimation = 0.0,
                                bigMine = true
                            }
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.droneShift,
                            statusAmount = 3,
                            targetPlayer = true
                        },
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                                yAnimation = 0.0,
                                bigMine = true
                            }
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.droneShift,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new AStatus
                        {
                            status = Status.evade,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                                yAnimation = 0.0,
                                bigMine = true
                            }
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.droneShift,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ASpawn
                        {
                            thing = new SpaceMine
                            {
                                yAnimation = 0.0,
                                bigMine = true
                            }
                        }
                    };
                }
        }
    }
}