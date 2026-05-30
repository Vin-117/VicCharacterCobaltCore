using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicShuffleSilo : Card, IRegisterable
{

    private static ISpriteEntry ShuffleSiloNormal = null!;
    private static ISpriteEntry ShuffleSiloFlipped = null!;

    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {

        ShuffleSiloNormal = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicShuffleSilo.png"));
        ShuffleSiloFlipped = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicShuffleSiloFlipped.png"));

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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicShuffleSilo", "name"]).Localize,
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
                        cost = 1,
                        flippable = true,
                        art = flipped ? ShuffleSiloNormal.Sprite : ShuffleSiloFlipped.Sprite
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = true,
                        art = flipped ? ShuffleSiloNormal.Sprite : ShuffleSiloFlipped.Sprite
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = true,
                        art = flipped ? ShuffleSiloNormal.Sprite : ShuffleSiloFlipped.Sprite
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
                        new AMove
                        {
                            targetPlayer = true,
                            dir = 1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0
                            }
                        },
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AMove
                        {
                            targetPlayer = true,
                            dir = 1
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0,
                                missileType = MissileType.heavy
                            }
                        },
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AMove
                        {
                            targetPlayer = false,
                            dir = 2
                        },
                        new ASpawn
                        {
                            thing = new Missile
                            {
                                yAnimation = 0.0
                            },
                            offset = 2
                        },
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