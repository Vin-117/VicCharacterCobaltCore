using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicEngineBoosterCard : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicEngineBoosterCard", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicDrone.png")).Sprite,
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
                        cost = 2
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 2
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 2,
                        retain = true,
                        buoyant = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 2
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
                            thing = new EngineBooster
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            },
                            dialogueSelector = ".VicEngineBooster"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new EngineBooster
                            {
                                yAnimation = 0.0,
                                targetPlayer = true,
                                bubbleShield = true
                            },
                            dialogueSelector = ".VicEngineBooster"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new EngineBooster
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            },
                            dialogueSelector = ".VicEngineBooster"
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new EngineBooster
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            },
                            dialogueSelector = ".VicEngineBooster"
                        }
                    };
                }
        }
    }
}