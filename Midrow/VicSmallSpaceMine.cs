using Nanoray.PluginManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nickel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VicCharacter.Midrow
{
    internal sealed class VicSmallSpaceMine : StuffBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VicSmallSpaceMineType
        {
            Normal
        }

        [JsonProperty]
        public VicSmallSpaceMineType StoneType = VicSmallSpaceMineType.Normal;

        public override Spr? GetIcon()
        {
            return ModEntry.Instance.SmallSpaceMineSmall.Sprite;
            
        }

        public override string GetDialogueTag() => "VicSmallSpaceMine";
        public override double GetWiggleAmount() => 1.0;
        public override double GetWiggleRate() => 1.0;
        public override bool IsHostile() => this.targetPlayer;

        public override List<Tooltip> GetTooltips()
        {
            List<Tooltip> tooltips = [
                new GlossaryTooltip($"{ModEntry.Instance.Package.Manifest.UniqueName}::{GetType()}")
                {
                    Icon = GetIcon()!,
                    Title = ModEntry.Instance.Localizations.Localize(["midrow", "VicSmallSpaceMine", StoneType.ToString(), "name"]),
                    TitleColor = Colors.midrow,
                    Description = ModEntry.Instance.Localizations.Localize(["midrow", "VicSmallSpaceMine", StoneType.ToString(), "description"])
                }
            ];
            if (this.bubbleShield)
                tooltips.Add((Tooltip)new TTGlossary("midrow.bubbleShield", Array.Empty<object>()));
            return tooltips;
        }
        public override bool Invincible()
        {
            return false;
        }

        public override List<CardAction>? GetActionsOnDestroyed(State s, Combat c, bool wasPlayer, int worldX)
        {
            return new List<CardAction>
            {
                new ASpaceMineAttack
                {
                    hurtAmount = 1,
                    targetPlayer = wasPlayer,
                    worldX = worldX
                }
            };
        }

        public override void DoDestroyedEffect(State s, Combat c)
        {
            s.AddShake(1.0);
            c.fx.Add(new DroneExplosion
            {
                pos = new Vec(x * 16, 60.0) + new Vec(7.5, 4.0)
            });
        }

        public override void Render(G g, Vec v)
        {
            Spr Sprite;
            Sprite = ModEntry.Instance.SmallSpaceMineMidrow.Sprite;
            //DrawWithHilight(g, Sprite, v + GetOffset(g), Mutil.Rand((double)x + 0.1) > 0.5, Mutil.Rand((double)x + 0.2) > 0.5);
            DrawWithHilight(g, Sprite, v + GetOffset(g));
        }

    }
}

