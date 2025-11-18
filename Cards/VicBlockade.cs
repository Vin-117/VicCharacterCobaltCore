using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicBlockade : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicBlockade", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicMine.png")).Sprite,
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
                        cost = 3,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicBlockade", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicBlockade", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = false,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicBlockade", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicBlockade", "desc"]))
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
                            card = new VicTrapCharge()
                            {
                            },
                            destination = CardDestination.Hand,
                            amount = 3,
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        
                        new AStatus()
                        {
                            status = Status.droneShift,
                            statusAmount = 2,
                            targetPlayer = true
                        },
                        new AAddCard()
                        {
                            card = new VicTrapCharge()
                            {
                            },
                            destination = CardDestination.Hand,
                            amount = 3,
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicTrapCharge()
                            {
                            },
                            destination = CardDestination.Hand,
                            amount = 3,
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicTrapCharge()
                            {
                            },
                            destination = CardDestination.Hand,
                            amount = 3,
                        }
                    };
                }
        }
    }
}