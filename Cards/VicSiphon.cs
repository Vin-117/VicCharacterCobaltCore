using FSPRO;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.Features;
using VicCharacter.Actions;

namespace VicCharacter.Cards;


public class VicSiphon : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicSiphon", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicSiphon.png")).Sprite,
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
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicSiphon", "desc"])),
                        cost = 1
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicSiphon", "descA"])),
                        cost = 0,
                        retain = false
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicSiphon", "descB"])),
                        cost = 1,
                        buoyant = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicSiphon", "desc"])),
                        cost = 0
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
                        new ACardSelect
                        {
                            browseSource = CardBrowse.Source.Hand,
                            browseAction = new ExhaustCardBrowseAction
                            {
                                OnSuccess =
                                [new AAddCard
                                {
                                    card = new VicAux()
                                    {
                                        upgrade = Upgrade.A
                                    },
                                    destination = CardDestination.Hand,
                                    amount = 1
                                }]
                            }
                        },
                        new ATooltipAction 
                        { Tooltips = new AAddCard
                        {
                            card = new VicAux()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Hand,
                            amount = 1
                        }.GetTooltips(s) 
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ACardSelect
                        {
                            browseSource = CardBrowse.Source.Hand,
                            browseAction = new ExhaustCardBrowseAction
                            {
                                OnSuccess =
                                [new AAddCard
                                {
                                    card = new VicAux()
                                    {
                                        upgrade = Upgrade.A
                                    },
                                    destination = CardDestination.Hand,
                                    amount = 1
                                }]
                            }
                        },
                        new ATooltipAction
                        { Tooltips = new AAddCard
                        {
                            card = new VicAux()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Hand,
                            amount = 1
                        }.GetTooltips(s)
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ACardSelect
                        {
                            browseSource = CardBrowse.Source.DrawOrDiscardPile,
                            browseAction = new ExhaustCardBrowseAction
                            {
                                OnSuccess =
                                [new AAddCard
                                {
                                    card = new VicAux()
                                    {
                                        upgrade = Upgrade.A
                                    },
                                    destination = CardDestination.Hand,
                                    amount = 1
                                }]
                            }
                        },
                        new ATooltipAction
                        { Tooltips = new AAddCard
                        {
                            card = new VicAux()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Hand,
                            amount = 1
                        }.GetTooltips(s)
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ACardSelect
                        {
                            browseSource = CardBrowse.Source.Hand,
                            browseAction = new ExhaustCardBrowseAction
                            {
                                OnSuccess =
                                [new AAddCard
                                {
                                    card = new VicAux()
                                    {
                                        upgrade = Upgrade.A
                                    },
                                    destination = CardDestination.Hand,
                                    amount = 1
                                }]
                            }
                        },
                        new ATooltipAction
                        { Tooltips = new AAddCard
                        {
                            card = new VicAux()
                            {
                                upgrade = Upgrade.A
                            },
                            destination = CardDestination.Hand,
                            amount = 1
                        }.GetTooltips(s)
                        }
                    };
                }
        }
    }

}