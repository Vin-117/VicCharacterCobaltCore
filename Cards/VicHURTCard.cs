using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicHURTCard : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicHURTCard", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicbasicMissile.png")).Sprite,
        });
    }

    public override CardData GetData(State state)
    {
        switch(this.upgrade)
        {
            case Upgrade.None: 
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true,
                        artTint = "f5ff00"
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = false,
                        artTint = "f5ff00"
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true,
                        artTint = "f5ff00"
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 3,
                        artTint = "f5ff00"
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
                            thing = new VicHURT
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicNuke"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new VicHURT
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicNuke"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new VicPAIN
                            {
                                yAnimation = 0.0
                            },
                            dialogueSelector = ".VicBigNuke"
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new VicHURT
                            {
                                yAnimation = 0.0
                            }
                        }
                    };
                }
        }
    }
}