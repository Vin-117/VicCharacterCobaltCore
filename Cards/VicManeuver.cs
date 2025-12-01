using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicManeuver : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicManeuver", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicManuever.png")).Sprite,
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
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicManeuver", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 0,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicManeuver", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicManeuver", "descB"])),
                        exhaust = false
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicManeuver", "desc"]))
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
                            card = new VicGlide()
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
                            card = new VicGlide()
                            {
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
                        new AAddCard()
                        {
                            card = new VicGlide()
                            {
                                upgrade = Upgrade.B
                            },
                            destination = CardDestination.Hand,
                            amount = 1
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicGlide()
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