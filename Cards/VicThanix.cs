using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicThanix : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicThanix", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/basicMissile.png")).Sprite,
        });
    }

    public override CardData GetData(State state)
    {

        switch (this.upgrade) 
        {
            case Upgrade.None:
                return new CardData
                {
                    cost = 1,
                    temporary = true
                };
            case Upgrade.A:
                return new CardData
                {
                    cost = 1,
                    temporary = true
                };
            case Upgrade.B:
                return new CardData
                {
                    cost = 0,
                    temporary = true
                };
            default:
                return new CardData
                {
                    cost = 1,
                    temporary = true
                };
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
                        new AAttack
                        {
                            damage = GetDmg(s, 3),
                            stunEnemy = true
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AAttack
                        {
                            damage = GetDmg(s, 3),
                            stunEnemy = true
                        },
                        new AAttack
                        {
                            damage = GetDmg(s, 3),
                            stunEnemy = true
                        },
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AAttack
                        {
                            damage = GetDmg(s, 4)
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AAttack
                        {
                            damage = GetDmg(s, 3),
                            stunEnemy = true
                        }
                    };
                }
        }
    }
}