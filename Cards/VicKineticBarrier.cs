using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicKineticBarrier : Card, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Cards.RegisterCard(new CardConfiguration
        {
            CardType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new CardMeta
            {
                deck = ModEntry.Instance.VicCharacter.Deck,
                rarity = Rarity.rare,
                dontOffer = false,
                upgradesTo = [Upgrade.A, Upgrade.B]
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicKineticBarrier", "name"]).Localize,
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
                        cost = 4,
                        exhaust = true
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 5,
                        flippable = true,
                        exhaust = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true
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
                            thing = new KineticBarrier
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicKineticBarrierUp"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new KineticBarrier
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicKineticBarrierUp"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new KineticBarrier
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicKineticBarrierUp",
                            offset = -1
                        },
                        new ASpawn
                        {
                            thing = new KineticBarrier
                            {
                                yAnimation = 0.0
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
                            thing = new KineticBarrier
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicKineticBarrierUp"
                        }
                    };
                }
        }
    }
}