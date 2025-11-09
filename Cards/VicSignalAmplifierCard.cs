using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter.Cards;


public class VicSignalAmplifierCard : Card, IRegisterable
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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicSignalAmplifierCard", "name"]).Localize,
            Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicDrone.png")).Sprite,
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
                        cost = 1
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 0
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 1
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
                        new ASpawn
                        {
                            thing = new SignalAmplifier
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            },
                            dialogueSelector = ".VicSatellite"
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new SignalAmplifierUpgraded
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            },
                            dialogueSelector = ".VicSatellite"
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new SignalAmplifier
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            },
                            dialogueSelector = ".VicSatelliteUpgraded"
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new ASpawn
                        {
                            thing = new SignalAmplifier
                            {
                                yAnimation = 0.0,
                                targetPlayer = true
                            }
                        }
                    };
                }
        }
    }
}