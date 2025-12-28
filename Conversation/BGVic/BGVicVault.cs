using System;
using FMOD;
using FSPRO;

namespace VicCharacter.Conversation;

public class BGVicVault : BG
{

    public void UpdateSounds()
    {
        Audio.Auto(Event.Scenes_CoreAmbience);
    }

    public override void Render(G g, double t, Vec offset)
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

    }

}