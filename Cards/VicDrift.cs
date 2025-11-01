using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicDrift : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicDrift", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicDodge.png")).Sprite,
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
                        cost = 0,
                        retain = false,
                        temporary = true,
                        exhaust = true
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 0,
                        retain = true,
                        temporary = true,
                        exhaust = true
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 0,
                        retain = false,
                        temporary = true,
                        exhaust = false
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 0,
                        retain = false,
                        temporary = true,
                        exhaust = true
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
                        new AStatus
                        {
                            status = Status.evade,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ADrawCard
                        {
                            count = 1
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.evade,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ADrawCard
                        {
                            count = 1
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.evade,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ADrawCard
                        {
                            count = 1
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.evade,
                            statusAmount = 1,
                            targetPlayer = true
                        },
                        new ADrawCard
                        {
                            count = 1
                        }
                    };
                }
        }
    }
}