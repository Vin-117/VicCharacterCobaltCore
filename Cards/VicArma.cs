using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;

public class VicArma : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicArma", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicArma.png")).Sprite,
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
                    cost = 0,
                    temporary = true
                };
            case Upgrade.B:
                return new CardData
                {
                    cost = 2,
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
                            damage = GetDmg(s, 6),
                            stunEnemy = true,
                            dialogueSelector = ".VicArma"
                        },
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AAttack
                        {
                            damage = GetDmg(s, 6),
                            stunEnemy = true,
                            fast = false,
                            dialogueSelector = ".VicArma"
                        },
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AAttack
                        {
                            damage = GetDmg(s, 10),
                            piercing = true,
                            stunEnemy = true,
                            dialogueSelector = ".VicArma"
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
                            stunEnemy = true,
                            dialogueSelector = ".VicArma"
                        }
                    };
                }
        }
    }
}