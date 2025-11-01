using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicCalibrate : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicCalibrate", "name"]).Localize,
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
                        cost = 2,
                        buoyant = false,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalibrate", "desc"]))
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 2,
                        buoyant = true,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalibrate", "descA"]))
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 1,
                        buoyant = false,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalibrate", "descB"]))
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1,
                        buoyant = false,
                        exhaust = true,
                        description = string.Format(ModEntry.Instance.Localizations.Localize(["card", "VicCalibrate", "desc"]))
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
                            },
                            destination = CardDestination.Discard,
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
                            card = new VicRecalibrate()
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
                            card = new VicThanix()
                            {
                            },
                            destination = CardDestination.Discard,
                            amount = 1,
                        }
                    };
                }
        }
    }
}