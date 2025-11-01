using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicRemember : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicRemember", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicRemember.png")).Sprite,
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
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRemember", "desc"])),
                        cost = 2,
                        singleUse = true,
                        retain = false
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRemember", "descA"])),
                        cost = 2,
                        singleUse = true,
                        retain = false
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRemember", "descB"])),
                        cost = 3,
                        singleUse = true,
                        retain = false
                    };
                }
            default:
                {
                    return new CardData
                    {
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicRemember", "desc"])),
                        cost = 3,
                        singleUse = true,
                        retain = false
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
                            browseAction = new ChooseACardToMakePermanent(),
                            browseSource = CardBrowse.Source.Deck,
                            filterTemporary = true,
                            allowCloseOverride = true,
                            dialogueSelector = ".VicRemember"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ACardSelect
                        {
                            browseAction = new CardSelectAddRetainForever(),
                            browseSource = CardBrowse.Source.Deck,
                            filterTemporary = false,
                            allowCloseOverride = true
                        },
                        new ACardSelect
                        {
                            browseAction = new CardSelectAddRetainForever(),
                            browseSource = CardBrowse.Source.Deck,
                            filterTemporary = false,
                            allowCloseOverride = true
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ACardSelect
                        {
                            browseAction = new CardSelectRemoveExhaustForever(),
                            browseSource = CardBrowse.Source.Deck,
                            filterExhaust = true,
                            filterTemporary = false,
                            allowCloseOverride = true
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ACardSelect
                        {
                            browseAction = new ChooseACardToMakePermanent(),
                            browseSource = CardBrowse.Source.Deck,
                            filterTemporary = true,
                            allowCloseOverride = true
                        }
                    };
                }
        }
    }
}