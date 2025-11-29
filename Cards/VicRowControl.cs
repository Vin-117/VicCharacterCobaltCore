using Microsoft.Xna.Framework.Media;
using Nanoray.PluginManager;
using Nickel;
using System;
using System.Collections.Generic;
using System.Reflection;
using VicCharacter.External;

namespace VicCharacter.Cards;

public class VicRowControl : Card, IRegisterable
{

    private static ISpriteEntry NormalArt = null!;
    private static ISpriteEntry UpgradedArt = null!;
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {

        NormalArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicRowControl.png"));
        UpgradedArt = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicRowControlUpgrade.png"));


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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicRowControl", "name"]).Localize,
            //Art = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicRowControl.png")).Sprite,
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
                        artTint = "59f790",
                        art = NormalArt.Sprite
                    };
                }
            case Upgrade.A:
                {
                    return new CardData
                    {
                        cost = 1,
                        buoyant = false,
                        exhaust = true,
                        artTint = "59f790",
                        art = NormalArt.Sprite
                    };
                }
            case Upgrade.B:
                {
                    return new CardData
                    {
                        cost = 2,
                        buoyant = false,
                        exhaust = true,
                        artTint = "59f790",
                        art = UpgradedArt.Sprite
                    };
                }
            default:
                {
                    return new CardData
                    {
                        cost = 2,
                        buoyant = false,
                        exhaust = true,
                        artTint = "59f790"
                    };
                }
        }
        ;
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
                            status = ModEntry.Instance.VicRowControlStatus.Status,
                            statusAmount = 1,
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
                            status = ModEntry.Instance.VicRowControlStatus.Status,
                            statusAmount = 1,
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
                            status = ModEntry.Instance.VicRowControlStatus.Status,
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
                            status = ModEntry.Instance.VicRowControlStatus.Status,
                            statusAmount = 1,
                            targetPlayer = true
                        }
                    };
                }
        }
    }
}