using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicMisdirection : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicMisdirection", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicJammer.png")).Sprite,
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
                        retain = true,
                        infinite = false
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        exhaust = true,
                        retain = true,
                        infinite = false
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 2,
                        exhaust = false,
                        retain = true,
                        infinite = false
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 2,
                        exhaust = true,
                        retain = true,
                        infinite = false
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
                            statusAmount = 1,
                            status = Status.backwardsMissiles,
                            targetPlayer = false
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            statusAmount = 1,
                            status = Status.backwardsMissiles,
                            targetPlayer = false
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            statusAmount = 1,
                            status = Status.backwardsMissiles,
                            targetPlayer = false
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            statusAmount = 1,
                            status = Status.backwardsMissiles,
                            targetPlayer = false
                        }
                    };
                }
        }
    }
}