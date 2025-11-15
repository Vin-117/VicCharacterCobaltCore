using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.Actions;

namespace VicCharacter.Cards;


public class VicAuxiliaryPower : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicAuxiliaryPower", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicAuxPower.png")).Sprite,
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
                        cost = 4,
                        exhaust = true
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 3,
                        exhaust = true
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 4,
                        exhaust = true
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 3,
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
                        new AStatus()
                        {
                            status = ModEntry.Instance.VicAuxPower.Status,
                            targetPlayer = true,
                            statusAmount = 1
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AStatus()
                        {
                            status = ModEntry.Instance.VicAuxPower.Status,
                            targetPlayer = true,
                            statusAmount = 1
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AStatus()
                        {
                            status = ModEntry.Instance.VicAuxSurge.Status,
                            targetPlayer = true,
                            statusAmount = 1
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AStatus()
                        {
                            status = ModEntry.Instance.VicAuxPower.Status,
                            targetPlayer = true,
                            statusAmount = 1
                        }
                    };
                }
        }  
    }
}