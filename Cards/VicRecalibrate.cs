﻿using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicRecalibrate : Card, IRegisterable
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
                dontOffer = true,
                upgradesTo = [Upgrade.A, Upgrade.B]
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicRecalibrate", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicLockdown.png")).Sprite,
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
                        exhaust = true,
                        temporary = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRecalibrate", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 0,
                        exhaust = true,
                        temporary = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRecalibrate", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 0,
                        temporary = true,
                        exhaust = true
                        //description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRecalibrate", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        temporary = true,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRecalibrate", "desc"]))
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
                        new AAddCard()
                        {
                            card = new VicThanix()
                            {
                                upgrade = Upgrade.A,
                                temporaryOverride = true
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
                            card = new VicThanix()
                            {
                                upgrade = Upgrade.B,
                                temporaryOverride = true
                            },
                            destination = CardDestination.Deck,
                            amount = 2,
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.powerdrive,
                            statusAmount = 1,
                            targetPlayer = true
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicThanix()
                            {
                                upgrade = Upgrade.A,
                                temporaryOverride = true
                            },
                            destination = CardDestination.Deck,
                            amount = 1,
                        }
                    };
                }
        }
    }
}