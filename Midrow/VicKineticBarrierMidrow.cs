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
    internal sealed class KineticBarrier : StuffBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KineticBarrierType
        {
            Normal
        }

        [JsonProperty]
        public KineticBarrierType StoneType = KineticBarrierType.Normal;

        public override Spr? GetIcon()
        {
            return ModEntry.Instance.KineticBarrierSmall.Sprite;
            
        }

        public override string GetDialogueTag() => "KineticBarrier";
        public override double GetWiggleAmount() => 0.0;
        public override double GetWiggleRate() => 1.0;
        public override bool IsHostile() => this.targetPlayer;

        public override List<Tooltip> GetTooltips()
        {
            List<Tooltip> tooltips = [
                new GlossaryTooltip($"{ModEntry.Instance.Package.Manifest.UniqueName}::{GetType()}")
                {
                    Icon = GetIcon()!,
                    Title = ModEntry.Instance.Localizations.Localize(["midrow", "KineticBarrier", StoneType.ToString(), "name"]),
                    TitleColor = Colors.midrow,
                    Description = ModEntry.Instance.Localizations.Localize(["midrow", "KineticBarrier", StoneType.ToString(), "description"])
                }
            ];
            if (this.bubbleShield)
                tooltips.Add((Tooltip)new TTGlossary("midrow.bubbleShield", Array.Empty<object>()));
            return tooltips;
        }
        public override bool Invincible()
        {
            return true;
        }



        public override List<CardAction>? GetActionsOnBonkedWhileInvincible(State s, Combat c, bool wasPlayer, StuffBase thing)
        {
            return new List<CardAction>
            {
                new ASpaceMineAttack
                {
                    hurtAmount = 1,
                    targetPlayer = wasPlayer,
                    worldX = this.x
                }
            };
        }

        public override List<CardAction>? GetActionsOnShotWhileInvincible(State s, Combat c, bool wasPlayer, int damage)
        {
            return new List<CardAction>
            {
                new AAttack
                {
                    damage = Card.GetActualDamage(s, 1),
                    targetPlayer = wasPlayer,
                    fromDroneX = this.x
                }
            };

        }

        public override void Render(G g, Vec v)
        {
            Spr Sprite;
            Sprite = ModEntry.Instance.KineticBarrierMidrow.Sprite;
            //DrawWithHilight(g, Sprite, v + GetOffset(g), Mutil.Rand((double)x + 0.1) > 0.5, Mutil.Rand((double)x + 0.2) > 0.5);
            DrawWithHilight(g, Sprite, v + GetOffset(g));
        }
        public override List<CardAction>? GetActionsOnDestroyed(State s, Combat c, bool wasPlayer, int worldX)
        {
            foreach (Artifact item in s.EnumerateAllArtifacts())
            {
                item.OnAsteroidIsDestroyed(s, c, wasPlayer, worldX);
            }
            return null;
        }
    }
}

