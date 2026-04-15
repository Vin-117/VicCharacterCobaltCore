using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicHeavySalvo : Card, IRegisterable
{

    private static ISpriteEntry TripleMissileArt = null!;
    private static ISpriteEntry DoubleMissileArt = null!;
    private static ISpriteEntry SingleMissileArt = null!;

    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        TripleMissileArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicHeavySalvoTriple.png"));
        DoubleMissileArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicHeavySalvo.png"));
        SingleMissileArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicHeavySalvoSingle.png"));

        helper.Content.Cards.RegisterCard(new CardConfiguration
        {

            CardType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new CardMeta
            {
                deck = ModEntry.Instance.VicCharacter.Deck,
                rarity = Rarity.rare,
                dontOffer = true,
                upgradesTo = [Upgrade.A, Upgrade.B]
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicHeavySalvo", "name"]).Localize,
            Art = (helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/Super Salvo.png")).Sprite),
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
                        flippable = true,
                        //artTint = "b40003",
                        //art = DoubleMissileArt.Sprite
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        flippable = true,
                        //artTint = "b40003",
                        //art = TripleMissileArt.Sprite
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 2,
                        infinite = true,
                        retain = true,
                        //artTint = "b40003",
                        //art = SingleMissileArt.Sprite
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
                            thing = new VicHeavySeeker
                            {
                                yAnimation = 0.0,
                            },
                            offset = -2
                        },
                        new ASpawn
                        {
                            thing = new VicHeavySeeker
                            {
                                yAnimation = 0.0
                            },
                            offset = -3,
                            dialogueSelector = ".VicHeavySeekerSwarm"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new VicHeavySeeker
                            {
                                yAnimation = 0.0,
                            },
                            offset = -2
                        },
                        new ASpawn
                        {
                            thing = new VicHeavySeeker
                            {
                                yAnimation = 0.0
                            },
                            offset = -3,
                            dialogueSelector = ".VicHeavySeekerSwarm"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new VicHeavySeeker
                            {
                                yAnimation = 0.0,
                            },
                            offset = -1
                        },
                        new ASpawn
                        {
                            thing = new VicHeavySeeker
                            {
                                yAnimation = 0.0
                            },
                            offset = 1,
                            dialogueSelector = ".VicHeavySeekerSwarm"
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