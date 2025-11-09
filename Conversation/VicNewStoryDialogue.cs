using FMOD;
using Microsoft.Xna.Framework.Graphics;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using VicCharacter.Artifacts;
using VicCharacter.External;
using static VicCharacter.Conversation.CommonDefinitions;

namespace VicCharacter.Conversation;

internal class VicNewStoryDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", new Dictionary<string, DialogueMachine>(){
            {"Vicc_Intro_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic ],
                bg = "BGRunStart",
                dialogue = [
                    new(AmCat, "Wake up, everybody!"),
                    new(AmVic, "squint", "Ugh..."),
                    new(AmCat, "Hm. You're not part of my usual crew."),
                    new(AmVic, "observe", "And this isn't my usual ship."),
                    new(AmVic, "neutraltalk", "Then again, I suppose I'm lucky to be alive after the Cobalt exploded."),
                    new(AmCat, "squint", "You were there when the Cobalt exploded?"),
                    new(AmVic, "observe", "...Yes. But I am not at liberty to discuss those details right now."),
                    new(AmCat, "squint", "...That sounds suspicious."),
                    new(AmVic, "neutraltalk", "So it is. Regardless, I have places to be. Drop me off at the nearest port."),
                    new(AmCat, "squint", "Hold on. Does 'places to be' include the Cobalt? Because that's where we're heading."),
                    new(AmVic, "pressuredstatic", "..."),
                    new(AmVic, "pressuredneutral", "Good catch."),
                    new(AmCat, "squint", "So you'll tag along?"),
                    new(AmVic, "neutraltalk", "I suppose so."),
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}