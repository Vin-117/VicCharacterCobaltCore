using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicLockdown : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicLockdown", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicLockdown.png")).Sprite,
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
                        temporary = true,
                        retain = false
                    };
                }
            case Upgrade.A:
                {
                    return new CardData 
                    {
                        cost = 0,
                        temporary = true,
                        retain = false
                    };
                }
            case Upgrade.B: 
                {
                    return new CardData 
                    {
                        cost = 0,
                        temporary = true,
                        retain = false,
                        exhaust = true
                    };
                }
            default:
                {
                    return new CardData 
                    {
                        cost = 0,
                        temporary = true,
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
                        new AStatus
                        {
                            status = Status.shield,
                            statusAmount = 2,
                            targetPlayer = true
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.shield,
                            statusAmount = 3,
                            targetPlayer = true
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.shield,
                            statusAmount = 2,
                            targetPlayer = true
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AStatus
                        {
                            status = Status.shield,
                            statusAmount = 2,
                            targetPlayer = true
                        }
                    };
                }
        }
    }
}