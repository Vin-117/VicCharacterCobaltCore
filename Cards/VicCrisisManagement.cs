using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicCrisisManagement : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicCrisisManagement", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/basicMissile.png")).Sprite,
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
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCrisisManagement", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 2,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCrisisManagement", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 0,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCrisisManagement", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCrisisManagement", "desc"]))
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
                            card = new VicLockdown()
                            {
                            },
                            destination = CardDestination.Deck,
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
                            card = new VicLockdown()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Deck,
                            amount = 1,
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicLockdown()
                            {
                            },
                            destination = CardDestination.Discard,
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
                            card = new VicLockdown()
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