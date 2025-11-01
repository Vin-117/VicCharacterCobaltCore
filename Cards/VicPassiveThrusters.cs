using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicPassiveThrusters : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicPassiveThrusters", "name"]).Localize,
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
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicPassiveThrusters", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicPassiveThrusters", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicPassiveThrusters", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicPassiveThrusters", "desc"]))
                    };
                }

        };
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
                            card = new VicDrift()
                            {
                            },
                            destination = CardDestination.Deck,
                            amount = 1,
                        },
                        new AAddCard()
                        {
                            card = new VicDrift()
                            {
                            },
                            destination = CardDestination.Discard,
                            amount = 1,
                            omitFromTooltips = true
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicDrift()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Hand,
                            amount = 1,
                        },
                        new AAddCard()
                        {
                            card = new VicDrift()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Discard,
                            amount = 1,
                            omitFromTooltips = true
                        }

                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AAddCard()
                        {
                            card = new VicDrift()
                            {
                            },
                            destination = CardDestination.Deck,
                            amount = 3,
                        },
                        new AAddCard()
                        {
                            card = new TrashFumes()
                            {
                            },
                            destination = CardDestination.Deck,
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
                            card = new VicDrift()
                            {
                            },
                            destination = CardDestination.Discard,
                            amount = 2,
                        }
                    };
                }
        }
    }
}