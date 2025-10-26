using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicSensorOverload : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicSensorOverload", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicbasicMissile.png")).Sprite,
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
                        retain = true
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        exhaust = true,
                        retain = true
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 0,
                        exhaust = true,
                        retain = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 2,
                        exhaust = true,
                        retain = true
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
                        new AStunShip(),
                        new AAddCard()
                        {
                            card = new TrashUnplayable()
                            {
                                temporaryOverride = true
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
                        new AStunShip(),
                        new AAddCard()
                        {
                            card = new TrashUnplayable()
                            {
                                temporaryOverride = true
                            },
                            destination = CardDestination.Discard,
                            amount = 1,
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStunShip(),
                        new AEnergy
                        {
                            changeAmount = 2
                        },
                        new AAddCard()
                        {
                            card = new TrashUnplayable()
                            {
                                temporaryOverride = true
                            },
                            destination = CardDestination.Discard,
                            amount = 2,
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AStunShip(),
                        new AAddCard()
                        {
                            card = new TrashUnplayable()
                            {
                                temporaryOverride = true
                            },
                            destination = CardDestination.Discard,
                            amount = 1,
                        }
                    };
                }
        }
    }
}