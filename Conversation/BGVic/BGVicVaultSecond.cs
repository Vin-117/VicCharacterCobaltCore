using System;
using FMOD;
using FSPRO;

namespace VicCharacter.Conversation;

public class BGVicVaultSecond : BG
{
    public override void Render(G g, double t, Vec offset)
    {
        Vec shifted_vec = new Vec(150.0, -60.0);
        BGVault.DrawVaultBg(g, letterbox: true, shuttle: false, lookAway: shifted_vec, extraDark: true, showOverlook: true);
    }

}