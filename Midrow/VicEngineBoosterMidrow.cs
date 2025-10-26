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
    internal sealed class EngineBooster : ShieldDrone
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EngineBoosterType
        {
            Normal
        }

        [JsonProperty]
        public EngineBoosterType DroneType = EngineBoosterType.Normal;

        private static ISpriteEntry DroneSprite = null!;
        private static ISpriteEntry DroneIcon = null!;

        public override Spr? GetIcon()
        {
            return ModEntry.Instance.EngineBoosterSmall.Sprite;
            
        }

        public override string GetDialogueTag() => "EngineBooster";
        public override double GetWiggleAmount() => 0.0;
        public override double GetWiggleRate() => 1.0;
        public override bool IsHostile() => this.targetPlayer;

        public override List<Tooltip> GetTooltips()
        {
            List<Tooltip> tooltips = [
                new GlossaryTooltip($"{ModEntry.Instance.Package.Manifest.UniqueName}::{GetType()}")
                {
                    Icon = GetIcon()!,
                    flipIconY = targetPlayer,
                    Title = ModEntry.Instance.Localizations.Localize(["midrow", "EngineBooster", DroneType.ToString(), "name"]),
                    TitleColor = Colors.midrow,
                    Description = ModEntry.Instance.Localizations.Localize(["midrow", "EngineBooster", DroneType.ToString(), "description"])
                }
            ];
            if (this.bubbleShield)
                tooltips.Add((Tooltip)new TTGlossary("midrow.bubbleShield", Array.Empty<object>()));
            return tooltips;
        }

        public override bool IsFriendly()
        {
            return targetPlayer;
        }


        public override List<CardAction>? GetActions(State s, Combat c)
        {
            return new List<CardAction>
            {
                new AAttack
                {
                    isBeam = true,
                    fromDroneX = x,
                    targetPlayer = targetPlayer,
                    damage = 0,
                    status = Status.evade,
                    statusAmount = 1
                }
            };
        }

        public override void Render(G g, Vec v)
        {
            Spr Sprite;
            Sprite = ModEntry.Instance.EngineBoosterMidrow.Sprite;
            DrawWithHilight(g, Sprite, v + GetOffset(g), flipX: false, targetPlayer);
        }
    }
}

