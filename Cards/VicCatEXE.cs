using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicCatEXE : Card, IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        helper.Content.Cards.RegisterCard(new CardConfiguration
        {
            CardType = MethodBase.GetCurrentMethod()!.DeclaringType!,
            Meta = new CardMeta
            {
                deck = Deck.colorless,
                rarity = Rarity.common,
                dontOffer = false,
                upgradesTo = [Upgrade.A, Upgrade.B]
            },
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicCatEXECard", "name"]).Localize,
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
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCatEXECard", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 0,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCatEXECard", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCatEXECard", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCatEXECard", "desc"]))
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
                        new ACardOffering
                        {
                            amount = 2,
                            limitDeck = ModEntry.Instance.VicCharacter.Deck,
                            makeAllCardsTemporary = true,
                            overrideUpgradeChances = false,
                            canSkip = false,
                            inCombat = true,
                            discount = -1
                            //dialogueSelector = $".summon{ModEntry.Instance.BlochDeck.UniqueName}"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ACardOffering
                        {
                            amount = 2,
                            limitDeck = ModEntry.Instance.VicCharacter.Deck,
                            makeAllCardsTemporary = true,
                            overrideUpgradeChances = false,
                            canSkip = false,
                            inCombat = true,
                            discount = -1
                            //dialogueSelector = $".summon{ModEntry.Instance.BlochDeck.UniqueName}"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ACardOffering
                        {
                            amount = 3,
                            limitDeck = ModEntry.Instance.VicCharacter.Deck,
                            makeAllCardsTemporary = true,
                            overrideUpgradeChances = false,
                            canSkip = false,
                            inCombat = true,
                            discount = -1
                            //dialogueSelector = $".summon{ModEntry.Instance.BlochDeck.UniqueName}"
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ACardOffering
                        {
                            amount = 2,
                            limitDeck = ModEntry.Instance.VicCharacter.Deck,
                            makeAllCardsTemporary = true,
                            overrideUpgradeChances = false,
                            canSkip = false,
                            inCombat = true,
                            discount = -1
                            //dialogueSelector = $".summon{ModEntry.Instance.BlochDeck.UniqueName}"
                        }
                    };
                }
        }
    }
}