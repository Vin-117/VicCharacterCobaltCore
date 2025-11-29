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
    internal sealed class ShifterDroneUpgradedLeft : AttackDrone
    {

        public bool rightflip;

        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShifterDroneUpgradedLeftType
        {
            Normal
        }

        [JsonProperty]
        public ShifterDroneUpgradedLeftType DroneType = ShifterDroneUpgradedLeftType.Normal;

        private static ISpriteEntry DroneSprite = null!;
        private static ISpriteEntry DroneIcon = null!;

        public override Spr? GetIcon()
        {

            if (!rightflip)
            {
                return ModEntry.Instance.ShiftDroneUpgradedLeftSmall.Sprite;
            }
            else 
            {
                return ModEntry.Instance.ShiftDroneUpgradedRightSmall.Sprite;
            }
        }

        public override string GetDialogueTag() => "VicShifterDroneUpgradedTag";
        public override double GetWiggleAmount() => 0.0;
        public override double GetWiggleRate() => 1.0;
        public override bool IsHostile() => this.targetPlayer;

        public override List<Tooltip> GetTooltips()
        {
            if (!rightflip)
            {
                List<Tooltip> tooltips = [
                    new GlossaryTooltip($"{ModEntry.Instance.Package.Manifest.UniqueName}::{GetType()}")
                {
                    Icon = GetIcon()!,
                    flipIconY = targetPlayer,
                    Title = ModEntry.Instance.Localizations.Localize(["midrow", "ShifterDroneUpgradedLeft", DroneType.ToString(), "name"]),
                    TitleColor = Colors.midrow,
                    Description = ModEntry.Instance.Localizations.Localize(["midrow", "ShifterDroneUpgradedLeft", DroneType.ToString(), "description"])
                }
                ];
                if (this.bubbleShield)
                    tooltips.Add((Tooltip)new TTGlossary("midrow.bubbleShield", Array.Empty<object>()));
                return tooltips;
            }
            else 
            {
                List<Tooltip> tooltips = [
                    new GlossaryTooltip($"{ModEntry.Instance.Package.Manifest.UniqueName}::{GetType()}")
                {
                    Icon = GetIcon()!,
                    flipIconY = targetPlayer,
                    Title = ModEntry.Instance.Localizations.Localize(["midrow", "ShifterDroneUpgradedRight", DroneType.ToString(), "name"]),
                    TitleColor = Colors.midrow,
                    Description = ModEntry.Instance.Localizations.Localize(["midrow", "ShifterDroneUpgradedRight", DroneType.ToString(), "description"])
                }
                ];
                if (this.bubbleShield)
                    tooltips.Add((Tooltip)new TTGlossary("midrow.bubbleShield", Array.Empty<object>()));
                return tooltips;
            }
        }

        public override bool IsFriendly()
        {
            return !targetPlayer;
        }


        public override List<CardAction>? GetActions(State s, Combat c)
        {

            if (!rightflip)
            {
                return new List<CardAction>
                {
                    new AAttack
                    {
                        fromDroneX = x,
                        targetPlayer = targetPlayer,
                        damage = 0,
                        moveEnemy = -3
                    },
                };
            }
            else
            {
                return new List<CardAction>
                {
                    new AAttack
                    {
                        fromDroneX = x,
                        targetPlayer = targetPlayer,
                        damage = 0,
                        moveEnemy = 3
                    },
                };
            }
        }

        public override void Render(G g, Vec v)
        {

            if (!rightflip)
            {
                Spr Sprite;
                Sprite = ModEntry.Instance.ShiftDroneUpgradedLeft.Sprite;
                DrawWithHilight(g, Sprite, v + GetOffset(g), flipX: false, targetPlayer);
            }
            else 
            {
                Spr Sprite;
                Sprite = ModEntry.Instance.ShiftDroneUpgradedRight.Sprite;
                DrawWithHilight(g, Sprite, v + GetOffset(g), flipX: false, targetPlayer);
            }
        }
    }
}

