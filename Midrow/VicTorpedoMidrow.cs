﻿using Nanoray.PluginManager;
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
    internal sealed class VicTorpedo : Missile
    {

        public static Color exhaustColor = new Color("fff387");

        [JsonConverter(typeof(StringEnumConverter))]
        public enum VicTorpedoType
        {
            Normal
        }

        [JsonProperty]
        public VicTorpedoType MissileType = VicTorpedoType.Normal;

        public override Spr? GetIcon()
        {
            return ModEntry.Instance.TorpedoSmall.Sprite;
        }

        public override string GetDialogueTag() => "Torpedo";

        public override List<Tooltip> GetTooltips()
        {
            List<Tooltip> tooltips = [
                new GlossaryTooltip($"{ModEntry.Instance.Package.Manifest.UniqueName}::{GetType()}")
                {
                    Icon = GetIcon()!,
                    flipIconY = targetPlayer,
                    Title = ModEntry.Instance.Localizations.Localize(["midrow", "Torpedo", MissileType.ToString(), "name"]),
                    TitleColor = Colors.midrow,
                    Description = ModEntry.Instance.Localizations.Localize(["midrow", "Torpedo", MissileType.ToString(), "description"])
                }
            ];
            if (this.bubbleShield)
                tooltips.Add((Tooltip)new TTGlossary("midrow.bubbleShield", Array.Empty<object>()));
            return tooltips;
        }

        public override List<CardAction>? GetActions(State s, Combat c)
        {
            return new List<CardAction>
            {
                new AMissileHit
                {
                    worldX = x,
                    outgoingDamage = 2,
                    targetPlayer = targetPlayer,
                    status = Status.lockdown,
                    statusAmount = 1
                }
            };
        }

        public override void Render(G g, Vec v)
        {
            Vec offset = GetOffset(g, doRound: true);
            Vec vec = new Vec(Math.Sin((double)x + g.state.time * 10.0), Math.Cos((double)x + g.state.time * 20.0 + Math.PI / 2.0)).round();
            offset += vec;
            int num = ((missileData[missileType].seeking && g.state.route is Combat c) ? Math.Sign(GetSeekerImpact(g.state, c) - x) : 0);
            Vec vec2 = v + offset;
            bool flag = targetPlayer;
            bool flag2 = false;
            Spr spr = ModEntry.Instance.TorpedoMidrow.Sprite;
            

            Vec vec3 = default(Vec);
            if (num > 0)
            {
                vec3 += new Vec(-6.0, targetPlayer ? 4 : (-4));
            }

            if (num < 0)
            {
                vec3 += new Vec(6.0, targetPlayer ? 4 : (-4));
            }

            if (!targetPlayer)
            {
                vec3 += new Vec(0.0, 21.0);
            }

            Vec vec4 = vec2 + vec3 + new Vec(7.0, 8.0);
            bool flag4;
            Spr? id = exhaustSprites.GetModulo((int)(g.state.time * 36.0 + (double)(x * 10)));
            double num2 = vec4.x - 5.0;
            double y = vec4.y + (double)((!targetPlayer) ? 14 : 0);
            Vec? originRel = new Vec(0.0, 1.0);
            flag4 = !targetPlayer;
            bool flipX = flag2;
            bool flipY = flag4;
            Color? color = missileData[missileType].exhaustColor;
            Draw.Sprite(id, num2, y, flipX, flipY, 0.0, null, originRel, null, null, color);
            Spr id2 = spr;
            flag4 = flag;
            DrawWithHilight(g, id2, vec2, flag2, flag4);
            Glow.Draw(vec4 + new Vec(0.5, -2.5), 25.0, missileData[missileType].exhaustColor * new Color(1.0, 0.5, 0.5).gain(0.2 + 0.1 * Math.Sin(g.state.time * 30.0 + (double)x) * 0.5));
        }
    }
}

