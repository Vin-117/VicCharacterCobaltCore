using System.Collections.Generic;
using System.Reflection;
using Nanoray.PluginManager;
using Nickel;

namespace VicCharacter.Cards;


public class VicGlide : Card, IRegisterable
{

    private static ISpriteEntry GlideArtNormal = null!;
    private static ISpriteEntry GlideArtFlipped = null!;

    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {

        GlideArtNormal = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicGlide.png"));
        GlideArtFlipped = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/Card/VicGlideFlipped.png"));

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
            Name = ModEntry.Instance.AnyLocalizations.Bind(["card", "VicGlide", "name"]).Localize,
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
                        exhaust = true,
                        retain = true,
                        flippable = false,
                        art = flipped ? GlideArtFlipped.Sprite : GlideArtNormal.Sprite
                    };
                }
            case Upgrade.A:
                {
                    return new CardData 
                    {
                        cost = 0,
                        temporary = true,
                        exhaust = false,
                        retain = true,
                        flippable = true,
                        art = flipped ? GlideArtFlipped.Sprite : GlideArtNormal.Sprite
                    };
                }
            case Upgrade.B: 
                {
                    return new CardData 
                    {
                        cost = 0,
                        temporary = true,
                        exhaust = true,
                        retain = true,
                        flippable = true,
                        art = flipped ? GlideArtFlipped.Sprite : GlideArtNormal.Sprite
                    };
                }
            default:
                {
                    return new CardData 
                    {
                        cost = 0,
                        temporary = true,
                        exhaust = true,
                        retain = true,
                        flippable = false,
                        art = flipped ? GlideArtFlipped.Sprite : GlideArtNormal.Sprite
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
                        new AMove
                        {
                            dir = -2,
                            targetPlayer = true
                        }
                    };
                }
            case Upgrade.A:
                {
                    return new List<CardAction>
                    {
                        new AMove
                        {
                            dir = -1,
                            targetPlayer = true
                        },
                        new AMove
                        {
                            dir = -1,
                            targetPlayer = true
                        }
                    };
                }
            case Upgrade.B:
                {
                    return new List<CardAction>
                    {
                        new AMove
                        {
                            dir = -2,
                            targetPlayer = true
                        }
                    };
                }
            default:
                {
                    return new List<CardAction>
                    {
                        new AMove
                        {
                            dir = -2,
                            targetPlayer = true
                        }
                    };
                }
        }
    }
}