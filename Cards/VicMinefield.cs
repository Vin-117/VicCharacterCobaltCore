using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicMinefield : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicMinefield", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicMeteor.png")).Sprite,
        });
    }

    public override CardData GetData(State state)
    {
        switch (this.upgrade)
        {
            case Upgrade.None:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = false
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = false
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = false
                    };
                }
        }



    }

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
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            },
                            offset = 1
                        },
                        new ASpawn
                        {
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            },
                            offset = -1
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
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ASpawn
                        {
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            },
                            offset = 1
                        },
                        new ASpawn
                        {
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            },
                            offset = -1
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            }
                        },
                        new AMove
                        {
                            dir = 2,
                            targetPlayer = true
                        },
                        new ASpawn
                        {
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            }
                        },
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
                            thing = new VicSmallSpaceMine
                            {
                                yAnimation = 0.0
                            }
                        }
                    };
                }
        }
    }
}