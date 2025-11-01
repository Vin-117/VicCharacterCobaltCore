using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicPlan : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicPlan", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicPlan.png")).Sprite,
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
                        cost = 0,
                        exhaust = true,
                        temporary = true,
                        retain = true
                    };
                }
            case Upgrade.A:
                {
                    return new CardData 
                    {
                        cost = 0,
                        exhaust = true,
                        temporary = true,
                        retain = true
                    };
                }
            case Upgrade.B: 
                {
                    return new CardData 
                    {
                        cost = 0,
                        exhaust = true,
                        temporary = true,
                        retain = true
                    };
                }
            default:
                {
                    return new CardData 
                    {
                        cost = 0,
                        exhaust = true,
                        temporary = true,
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
                        new ADrawCard
                        {
                            count = 2
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ADrawCard
                        {
                            count = 3
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ADrawCard
                        {
                            count = 2
                        },
                        new AAddCard()
                        {
                            card = new VicPlan()
                            {
                                upgrade = Upgrade.B
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
                        new ADrawCard
                        {
                            count = 2
                        }
                    };
                }
        }
    }
}