using FMOD;
using FSPRO;
using System;
using System.Data;

namespace VicCharacter.Conversation;

public class BGVicVaultThird : BG
{

    public bool vic_transition_cutscene;
    public bool vic_trigger_alarm;
    public bool vic_exploded;
    public double vic_rumble_timer;
    public double vic_cutscene_age;

    public override void OnAction(State s, string action)
    {
        switch (action)
        {
            case "vic_transition_cutscene":
                vic_transition_cutscene = true;
                break;
            case "vic_trigger_alarm":
                vic_trigger_alarm = true;
                break;
            case "vic_exploded":
                vic_exploded = true;
                break;
            case "vic_killfx":
                vic_trigger_alarm = vic_exploded = false;
                s.shake = vic_cutscene_age = 0;
                break;
        }
    }


    public override void Render(G g, double t, Vec offset)
    {

        if (vic_transition_cutscene)
        {
            Vec shifted_vec = new Vec(150.0, 25.0);
            BGVault.DrawVaultBg(g, letterbox: true, shuttle: false, lookAway: shifted_vec);

            //Color color2 = (extraDark ? new Color(0.0, 0.5, 1.0).gain(0.3) : new Color(0.0, 0.5, 1.0));
            Color color2 = new Color(0.0, 0.5, 1.0).gain(0.3);

            Draw.Fill(color2.gain(0.1), BlendMode.Screen);

            Spr? id3 = ModEntry.Instance.SmallShip.Sprite;
            double y = 200.0 + Math.Sin(g.state.time * 1.5) * 3.0;
            Vec vec3 = new Vec(1.0, 1.0);
            Draw.Sprite(id3, 100, y, flipX: false, flipY: false, 0.0, null, vec3);

            if (vic_trigger_alarm)
            {

                if (vic_exploded)
                {
                    vic_rumble_timer += g.dt;
                    vic_cutscene_age += g.dt;
                    Draw.Fill(new Color(0.25, 0.5, 1).gain(vic_rumble_timer / 3.5), BlendMode.Screen);
                    Draw.Fill(Colors.white.fadeAlpha(vic_rumble_timer / 5));
                    Audio.Auto(Event.Scenes_CobaltCritical);
                }
                else 
                {
                    vic_rumble_timer = 0.2;
                }
                Audio.Auto(Event.Scenes_CoreAlarmFromOutside);
                g.state.shake = vic_rumble_timer;
            }

        }
        else 
        {
            Color color = new Color(0.0, 0.1, 0.2).gain(0.5);
            Draw.Fill(color);
            BGComponents.NormalStars(g, t, offset);
            BGComponents.RegularNebula(g, offset, color);
        }
    }

}