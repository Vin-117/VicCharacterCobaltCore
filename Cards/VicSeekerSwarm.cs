using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicSeekerSwarm : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicSeekerSwarm", "name"]).Localize,
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
                        cost = 2,
                        infinite = false
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 2,
                        infinite = false
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        infinite = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 2,
                        infinite = false
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
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = -1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = 1
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = 1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            }
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = -1
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
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            }
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = 1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = -1
                        }
                    };
                }
        }
    }
}