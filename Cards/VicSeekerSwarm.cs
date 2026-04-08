using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicSeekerSwarm : Card, IRegisterable
{

    private static ISpriteEntry DoubleMissileArt = null!;
    private static ISpriteEntry SingleMissileArt = null!;

    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {

        DoubleMissileArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicSeekerSwarm.png"));
        SingleMissileArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicSeekerSwarmSingle.png"));

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
            //Art = (helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicSeekerSwarm.png")).Sprite),
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
                        infinite = false,
                        artTint = "9944de",
                        art = DoubleMissileArt.Sprite
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 2,
                        retain = true,
                        artTint = "9944de",
                        art = DoubleMissileArt.Sprite
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 2,
                        exhaust = true,
                        flippable = true,
                        artTint = "9944de",
                        art = DoubleMissileArt.Sprite
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 2,
                        infinite = false,
                        //artTint = "9944de"
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
                            offset = 1,
                            dialogueSelector = ".VicSeekerSwarm"
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
                            offset = -1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker
                            },
                            offset = 1,
                            dialogueSelector = ".VicSeekerSwarm"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker,
                                bubbleShield = true
                            },
                            offset = -1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.seeker,
                                bubbleShield = true
                            },
                            offset = 1,
                            dialogueSelector = ".VicSeekerSwarm"
                        },
                        new AMove
                        {
                           dir = -4,
                           targetPlayer = true
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
                            offset = -1,
                            dialogueSelector = ".VicSeekerSwarm"
                        }
                    };
                }
        }
    }
}