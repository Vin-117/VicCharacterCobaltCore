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
                    new(AmVic, "annoyed", "Figures. Blasted experimentation with the Cobalt..."),
                    new(AmCat, "squint", "...You sound suspiciously well informed."),
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
                    new(AmVic, "neutraltalk", "Apologies. My name is Garrus."),
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
            {"Vic_AfterCrystal_00", new(){
                type = NodeType.@event,
                lookup = ["after_crystal"],
                bg = "BGCrystalNebula",
                allPresent = [AmVic],
                once = true,
                priority = true,
                requiredScenes = ["Vic_Intro_0"],
                dialogue = [
                    new(AmVic, "observe", "...Was that a time crystal?"),
                    new(AmCat, "Yep!"),
                    new(AmVic, "pda", "Figures. Readings like that...you don't forget them."),
                    new(AmCat, "You've encountered time crystals before?"),
                    new(AmVic, "pensive", "Yes."),
                    new(AmVic, "pensive", "They're dangerous."),
                    new(AmCat, "worried", "...Are you okay?"),
                    new(AmVic, "observe", "No. But this isn't the time."),
                    new(AmVic, "neutraltalk", "Let's keep moving."),
                ]
            }},
            {"Vic_BeforeCobalt_00", new(){
                type = NodeType.@event,
                lookup = ["before_theCobalt"],
                bg = "BGTheCobalt",
                allPresent = [AmVic],
                once = true,
                priority = true,
                requiredScenes = ["Vic_AfterCrystal_00"],
                dialogue = [
                    new(AmVic, "pressuredneutral", "That's the Cobalt?"),
                    new(AmCat, "Yep!"),
                    new(AmVic, "pressuredneutral", "It's stuck inside of a singularity."),
                    new(AmCat, "Also yep!"),
                    new(AmVic, "pressured", "I...wasn't expecting this."),
                    new(AmCat, "What were you expecting?"),
                    new(AmVic, "pressured", "I...I'm not sure."),
                    new(AmVic, "pressuredneutral", "Answers, maybe? I still remember it exploding, but..."),
                    new(AmVic, "pensive", "I can't remember. Nothing makes sense."),
                    new(AmVic, "pressuredneutral", "What happens now?"),
                    new(AmCat, "You fight the Cobalt."),
                    new(AmVic, "pdapressured", "...How? We can't fight it when it's in there."),
                    new(AmCat, "I upload myself to the Cobalt and bring it out."),
                    new(AmVic, "pda", "...Wait a second, if you do that, the main security system will-"),
                    new(AmCat, "Yep! Gotta go!"),
                ]
            }},
            {"Vic_DrakeFirstFight_00", new(){
                type = NodeType.@event,
                lookup = ["before_pirate"],
                requiredScenes = ["Pirate_1"],
                allPresent = [AmVic],
                nonePresent = [AmDrake],
                once = true,
                priority = true,
                dialogue = [
                    new(AmVic, "pda", "Some pirate is hailing us."),
                    new(AmVic, "neutraltalk", "Likely nothing of concern. These pirates are a dime a dozen."),
                    new(AmDrake, "mad", "Your intercom is on, jerk.", flipped: true),
                    new(AmVic, "neutraltalk", "I'm well aware."),
                    new(AmVic, "pda", "Mind getting out of the way? We have places to be."),
                    new(AmDrake, "mad", "You think I'm going to let you walk after something like that!?", flipped: true),
                    new(AmVic, "annoyed", "I was hoping you'd have the sense to tell that you're outmatched."),
                ]
            }},
            {"Vic_JumboFirstFight_00", new(){
                type = NodeType.@event,
                lookup = ["miner_midcombat"],
                requiredScenes = ["Miner_1"],
                allPresent = [AmVic],
                once = true,
                priority = true,
                dialogue = [
                    new(AmJumbo, "Dead or alive, baby!", flipped: true),
                    new(AmVic, "happy", "Alive!"),
                    new(AmVic, "observe", "...Wait. Jumbo? Is that you?"),
                    new(AmJumbo, "Oh, hey Garrus. Fancy meeting you here.", flipped: true),
                    new(AmVic, "happyneutral", "Small universe, isn't it? What have you been up to?"),
                    new(AmJumbo, "Oh you know, hunting a bounty.", flipped: true),
                    new(AmVic, "happyneutral", "As one does. Who's ship has a bounty?"),
                    new(AmJumbo, "Yours.", flipped: true),
                    new(AmVic, "panic", "Wait what?"),
                ]
            }},
            {"Vic_JumboFirstFight_11", new(){
                type = NodeType.@event,
                lookup = ["miner_midcombat"],
                requiredScenes = ["Miner_1"],
                allPresent = [AmVic],
                nonePresent = [AmDrake],
                once = true,
                priority = true,
                dialogue = [

                    new(AmVic, "neutraltalk", "I hadn't realized we were in a time loop."),
                    new(AmJumbo, "I figured.", flipped: true),
                    new(AmVic, "pressured", "Nothing really matters, does it?"),
                    new(AmJumbo, "Nope.", flipped: true),
                    new(AmVic, "observe", "Hmm. Mind doing me a favor before we kill each other?"),
                    new(AmJumbo, "Sure.", flipped: true),
                    new(AmVic, "neutraltalk", "Who placed the bounty?"),
                    new(AmJumbo, "Drake.", flipped: true),
                    new(AmVic, "doubtful", "Figures. Thank you."),
                ]
            }},
            {"Jumbo_Vic_Banter", new(){
                type = NodeType.combat,
                allPresent = [AmVic, AmJumbo],
                turnStart = true,
                enemyIntent = "wideBigAttack",
                maxTurnsThisCombat = 1,
                oncePerCombatTags = [ "MinerGonnaSmackYa4X" ],
                dialogue = [
                    new(AmJumbo, "Do you think this is too many cannons?"),
                    new(AmVic, "neutraltalk", "I think you need more missile bays."),
                ]
            }},

            {"Vic_Drake_Meet_00", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmDrake ],
                requiredScenes = ["Vic_JumboFirstFight_11"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmVic, "neutraltalk", "Drake? I need to ask you something."),
                    new(AmDrake, "What's up?"),
                    new(AmVic, "annoyed", "Jumbo told me you put a bounty on our ship."),
                    new(AmDrake, "squint", "He's still spreading that around?"),
                    new(AmDrake, "squint", "That was a FAKE bounty!"),
                    new(AmVic, "annoyed", "Why the hell did you even do that in the first place!?"),
                    new(AmDrake, "sly", "So I could distract and rob you guys."),
                    new(AmVic, "annoyed", "That's a stupid plan."),
                    new(AmDrake, "reallymad", "Shut up."),
                ]
            }},
            {"Vic_JumboFirstFight_22", new(){
                type = NodeType.@event,
                lookup = ["miner_midcombat"],
                requiredScenes = ["Vic_Drake_Meet_00"],
                allPresent = [AmVic, AmDrake],
                once = true,
                priority = true,
                dialogue = [

                    new(AmJumbo, "Oh look, my bounty just arrived.", flipped: true),
                    new(AmDrake, "mad", "Could you quit it with that?"),
                    new(AmDrake, "mad", "It's bad enough that my plan didn't work."),
                    new(AmDrake, "mad", "But now I have this old geezer on my case about it."),
                    new(AmVic, "annoyed", "Excuse me?"),
                    new(AmJumbo, "Hm. No.", flipped: true),
                    new(AmDrake, "reallymad", "Seriously?"),
                    new(AmJumbo, "You insulted a fellow professional.", flipped: true),
                    new(AmJumbo, "I'll have to kill you for that.", flipped: true),
                    new(AmDrake, "reallymad", "How the HELL does that make sense?!"),
                    new(AmDrake, "reallymad", "You'd literally blow him up with me!"),
                    new(AmVic, "happy", "You heard him, Drake."),
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}