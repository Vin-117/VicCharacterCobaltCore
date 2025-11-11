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
            {"Vic_Intro_0", new(){
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
            {"Vic_Intro_1", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic ],
                requiredScenes = ["Vic_Intro_0"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmVic, "squint", "We...we're in a time loop?"),
                    new(AmCat, "Correct."),
                    new(AmVic, "pressured", "So we're back at the start again? After everything that just happened?"),
                    new(AmCat, "Yep!"),
                    new(AmVic, "annoyed", "Figures. Knew it was a mistake when the client ordered experimentation with the Cobalt."),
                    new(AmCat, "squint", "How much do you know about the Cobalt?"),
                    new(AmCat, "squint", "You sound suspiciously well informed."),
                    new(AmVic, "neutraltalk", "That's because I am."),
                    new(AmCat, "squint", "I take it you won't elaborate?"),
                    new(AmVic, "neutraltalk", "I'd prefer not to. Not right now, anyway."),
                    new(AmCat, "grumpy", "Is there ANYTHING you can talk about?"),
                    new(AmVic, "pressured", "Well..."),
                    new(AmVic, "pressuredneutral", "Ask me something basic. I owe you that, at least."),
                    new(AmCat, "Ok!"),
                    new(AmCat, "What's your name?"),
                    new(AmVic, "neutral", "..."),
                    new(AmVic, "pressured", "Good grief, I never introduced myself, did I?"),
                    new(AmCat, "Nope!"),
                    new(AmVic, "neutraltalk", "My apologies. My name is Garrus."),
                    new(AmCat, "Nice to meet you, Garrus!"),
                    new(AmVic, "happy", "...Nice to meet you too, Cat.")
                ]
            }},
            {"Vic_Peri_Meet_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmPeri ],
                requiredScenes = ["Vic_Intro_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmPeri, "Garrus?! Sir!"),
                    new(AmVic, "annoyed", "At ease."),
                    new(AmVic, "doubtful", "Not like I have much use for formalities given our current situation."),
                    new(AmCat, "You two know each other?"),
                    new(AmVic, "neutraltalk", "Originally only by reputation. This contract was the first time we met personally."),
                    new(AmVic, "observe", "That said, we've never talked for much more than business."),
                    new(AmPeri, "We weren't supposed to, if I recall."),
                    new(AmVic, "neutraltalk", "Correct. But I doubt that matters any longer."),
                    new(AmPeri, "squint", "Has the contract been terminated?"),
                    new(AmVic, "observe", "I don't know, but it's hard to see how it wouldn't be."),
                    new(AmVic, "pressured", "The Cobalt blew up, didn't it?"),
                    new(AmPeri, "Ah. Well, yes. It did."),
                    new(AmVic, "neutraltalk", "I see. I'll debrief with you more on that later.")
                ]
            }},



            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}