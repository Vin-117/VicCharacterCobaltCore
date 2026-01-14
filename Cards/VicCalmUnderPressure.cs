using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicCalmUnderPressure : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicCalmUnderPressure", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicCalibrate.png")).Sprite,
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
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalmUnderPressure", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalmUnderPressure", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        exhaust = false,
                        infinite = false,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalmUnderPressure", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalmUnderPressure", "desc"]))
                    };
                }

        }
        ;
    }

    public override List<CardAction> GetActions(State s, Combat c)
    {
        switch (this.upgrade)
        {
            case Upgrade.None:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicPlan()
                            {
                            },
                            destination = CardDestination.Hand,
                            amount = 1,
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicPlan()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Hand,
                            amount = 1,
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ADiscard(),
                        new AAddCard()
                        {
                            card = new VicPlan()
                            {
                                upgrade = Upgrade.B
                            },
                            destination = CardDestination.Hand,
                            amount = 1,
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicPlan()
                            {
                            },
                            destination = CardDestination.Hand,
                            amount = 1,
                        }
                    };
                }
        }
    }
}