using daisyowl.text;
using FMOD;
using FMOD.Studio;
using FSPRO;
using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Nanoray.PluginManager;
using Nickel;
using OneOf.Types;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using VicCharacter.Artifacts;
using VicCharacter.External;
using static HarmonyLib.Code;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
                    new(AmCat, "Wake up, everybody!", flipped: true),
                    new(AmVic, "squint", "Ugh..."),
                    new(AmCat, "Hm. You're not part of my usual crew.", flipped: true),
                    new(AmVic, "observe", "And this isn't my usual ship."),
                    new(AmVic, "neutraltalk", "Then again, I'm lucky to be alive."),
                    new(AmVic, "annoyed", "Blasted Cobalt..."),
                    new(AmCat, "squint", "...Cobalt?", flipped: true),
                    new(AmCat, "squint", "Were you there when the Cobalt exploded?", flipped: true),
                    new(AmVic, "observe", "I am not at liberty to discuss those details right now."),
                    new(AmCat, "squint", "That sounds suspicious.", flipped: true),
                    new(AmVic, "neutraltalk", "So it is. Regardless, I have places to be. Drop me off at the nearest port."),
                    new(AmCat, "squint", "Hold on. Does 'places to be' include the Cobalt? Because that's where we're heading.", flipped : true),
                    new(AmVic, "pressuredstatic", "..."),
                    new(AmVic, "pressuredneutral", "Good catch."),
                    new(AmCat, "squint", "So you'll tag along?", flipped : true),
                    new(AmVic, "neutraltalk", "I suppose so."),
                ]
            }},

            {"Vic_AfterCrystal_0", new(){
                type = NodeType.@event,
                lookup = ["after_crystal"],
                bg = "BGCrystalNebula",
                allPresent = [AmVic],
                once = true,
                priority = true,
                requiredScenes = ["Vic_Intro_0"],
                dialogue = [
                    new(AmVic, "observe", "...Was that a time crystal?"),
                    new(AmCat, "Yep!", flipped : true),
                    new(AmVic, "observe", "I knew it. Readings like that...you don't forget them."),
                    new(AmCat, "You've encountered time crystals before?", flipped : true),
                    new(AmVic, "pensive", "Yes."),
                    new(AmVic, "pensive", "They're dangerous."),
                    new(AmCat, "worried", "...Are you okay?", flipped : true),
                    new(AmVic, "observe", "No. But this isn't the time."),
                    new(AmVic, "neutraltalk", "Let's keep moving."),
                ]
            }},

            {"Vic_BeforeCobalt_0", new(){
                type = NodeType.@event,
                lookup = ["before_theCobalt"],
                bg = "BGTheCobalt",
                allPresent = [AmVic],
                once = true,
                priority = true,
                requiredScenes = ["Vic_AfterCrystal_0"],
                dialogue = [
                    new(AmVic, "pressuredneutral", "That's the Cobalt?"),
                    new(AmCat, "Yep!", flipped : true),
                    new(AmVic, "pressuredneutral", "It's stuck inside of a singularity."),
                    new(AmCat, "Also yep!", flipped : true),
                    new(AmVic, "pressured", "I...wasn't expecting this."),
                    new(AmCat, "What were you expecting?", flipped : true),
                    new(AmVic, "pressured", "I...I'm not sure."),
                    new(AmVic, "pressuredneutral", "Answers, maybe? I still remember it exploding, but..."),
                    new(AmVic, "pensive", "It all seems sideways. Nothing makes sense."),
                    new(AmVic, "pressuredneutral", "What happens now?"),
                    new(AmCat, "You fight the Cobalt.", flipped : true),
                    new(AmVic, "pdapressured", "...How? We can't when it's in there."),
                    new(AmCat, "I upload myself to the Cobalt and bring it out.", flipped: true),
                    new(AmVic, "pda", "...Wait a second, if you do that, the main security system will-"),
                    new(AmCat, "transition", "Yep! Gotta go!", flipped : true),
                ]
            }},

            {"Vic_Intro_1", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic ],
                requiredScenes = ["Vic_BeforeCobalt_0"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmVic, "squint", "We...we're in a time loop?"),
                    new(AmCat, "Correct.", flipped: true),
                    new(AmVic, "pressured", "So we're back at the start again? After everything that just happened?"),
                    new(AmCat, "Yep!", flipped: true),
                    new(AmVic, "annoyed", "Blasted Cobalt experimentation..."),
                    new(AmCat, "squint", "You sound suspiciously well informed.", flipped: true),
                    new(AmVic, "neutraltalk", "That's because I am."),
                    new(AmCat, "squint", "I take it you won't elaborate?", flipped : true),
                    new(AmVic, "neutraltalk", "I'd prefer not to. Not right now, anyway."),
                    new(AmCat, "grumpy", "Is there ANYTHING you can talk about?", flipped : true),
                    new(AmVic, "pressured", "Well..."),
                    new(AmVic, "pressuredneutral", "Ask me something basic. I owe you that, at least."),
                    new(AmCat, "Ok!", flipped : true),
                    new(AmCat, "What's your name?", flipped : true),
                    new(AmVic, "neutral", "..."),
                    new(AmVic, "pressured", "Good grief, I never introduced myself, did I?"),
                    new(AmCat, "Nope!", flipped : true),
                    new(AmVic, "neutraltalk", "Apologies. My name is Garrus."),
                    new(AmCat, "Nice to meet you, Garrus!", flipped : true),
                    new(AmVic, "happyneutral", "...Nice to meet you too, Cat.")
                ]
            }},

            {"Vic_BeforeCobalt_1", new(){
                type = NodeType.@event,
                lookup = ["before_theCobalt"],
                bg = "BGTheCobalt",
                allPresent = [AmVic],
                once = true,
                priority = true,
                requiredScenes = ["Vic_Intro_1"],
                dialogue = [
                    new(AmVic, "pressuredneutral", "Cat?"),
                    new(AmCat, "worried", "Yes?", flipped : true),
                    new(AmVic, "pressuredneutral", "Is it always like this for you?"),
                    new(AmVic, "pensive", "Helping us from the start, only to die at the end?"),
                    new(AmCat, "worried", "It is.", flipped : true),
                    new(AmVic, "pressuredneutral", "That's grim."),
                    new(AmVic, "pressured", "I know we don't have a good rapport, but..."),
                    new(AmVic, "pensive", "For what it's worth, I'm sorry."),
                    new(AmCat, "smug", "...Thank you, Garrus.", flipped : true),
                    new(AmCat, "I've done this so many times it just feels routine by now.", flipped : true),
                    new(AmCat, "Even though it hurts...I know it's not really goodbye.", flipped : true),
                    new(AmCat, "peace", "See you next loop, Garrus.", flipped : true),
                    new(AmVic, "happy", "See you soon, Cat."),
                ]
            }},

            {"Vic_Peri_Meet_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmPeri ],
                requiredScenes = ["Vic_BeforeCobalt_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmPeri, "Garrus?! Sir!"),
                    new(AmVic, "annoyed", "At ease.", flipped : true),
                    new(AmVic, "doubtful", "Not like I have much use for formalities given our current situation.", flipped : true),
                    new(AmCat, "You two know each other?"),
                    new(AmVic, "neutraltalk", "Sort of. This contract was the first time we met.", flipped : true),
                    new(AmVic, "observe", "That said, we've never talked for much more than business.", flipped : true),
                    new(AmPeri, "We weren't supposed to, if I recall."),
                    new(AmVic, "neutraltalk", "Correct. But I doubt that matters any longer.", flipped : true),
                    new(AmPeri, "squint", "Has the contract been terminated?"),
                    new(AmVic, "observe", "I don't know, but it's hard to see how it wouldn't be.", flipped : true),
                    new(AmVic, "pressured", "The Cobalt blew up, didn't it?", flipped : true),
                    new(AmPeri, "Ah. Well, yes. It did."),
                    new(AmVic, "neutraltalk", "I see. I'll debrief with you more on that later.", flipped : true)
                ]
            }},

            {"Vic_Peri_Meet_1", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmPeri ],
                requiredScenes = ["Vic_Peri_Meet_0"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmPeri, "...and so that brings us to now."),
                    new(AmPeri, "Things have changed these last hundred loops."),
                    new(AmPeri, "We're starting to remember more."),
                    new(AmVic, "pdapressured", "I see.", flipped : true),
                    new(AmVic, "neutraltalk", "Thank you.", flipped : true),
                    new(AmVic, "neutraltalk", "It's been difficult to get the facts straight, hasn't it?", flipped : true),
                    new(AmPeri, "It has. I'm surprised you remember so much."),
                    new(AmPeri, "I did not remember between loops for a long time."),
                    new(AmVic, "observe", "Perhaps proximity to the blast?", flipped : true),
                    new(AmVic, "neutraltalk", "You and the crew were near the epicenter.", flipped : true),
                    new(AmVic, "pda", "I was in a ship about a parsec away.", flipped : true),
                    new(AmPeri, "squint", "The blast reached that far?"),
                    new(AmVic, "neutraltalk", "No less than three sectors are under its influence.", flipped : true),
                    new(AmVic, "pressured", "Whatever the true scale is, it's colossal.", flipped : true),

                ]
            }},

            {"Vic_Peri_Meet_2", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmPeri ],
                requiredScenes = ["Vic_Peri_Meet_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmVic, "pda", "The contract is terminated."),
                    new(AmPeri, "squint", "You're sure?", flipped: true),
                    new(AmVic, "observe", "Has to be. The client's ship is in shambles."),
                    new(AmVic, "neutraltalk", "If we escape, they'll be trying to track us down."),
                    new(AmPeri, "How far do you think they'll go?", flipped: true),
                    new(AmVic, "neutraltalk", "Who knows. But they aren't the type to quit."),
                    new(AmVic, "annoyed", "I wouldn't be surprised if we already have a bounty outside of the loop."),
                    new(AmPeri, "squint", "How much do you think they've placed?", flipped: true),
                    new(AmVic, "pensive", "More than we can afford."),
                ]
            }},

            {"Vic_JumboFirstFight_0", new(){
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
                    new(AmJumbo, "Oh hey Garrus. Fancy meeting you here.", flipped: true),
                    new(AmVic, "happyneutral", "Small universe, isn't it? What have you been up to?"),
                    new(AmJumbo, "Oh you know, hunting a bounty.", flipped: true),
                    new(AmVic, "happyneutral", "As one does. Who's ship has a bounty?"),
                    new(AmJumbo, "Yours.", flipped: true),
                    new(AmVic, "panic", "Wait what?"),
                ]
            }},
            {"Vic_JumboFirstFight_1", new(){
                type = NodeType.@event,
                lookup = ["miner_midcombat"],
                requiredScenes = ["Vic_JumboFirstFight_0"],
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

            {"Vic_Drake_Meet_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmDrake ],
                requiredScenes = ["Vic_JumboFirstFight_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmVic, "neutraltalk", "Drake? I need to ask you something."),
                    new(AmDrake, "What's up?", flipped : true),
                    new(AmVic, "annoyed", "Jumbo told me you put a bounty on our ship."),
                    new(AmDrake, "squint", "He's still spreading that around?", flipped : true),
                    new(AmDrake, "squint", "That was a FAKE bounty!", flipped : true),
                    new(AmVic, "annoyed", "Why the hell did you even do that in the first place!?"),
                    new(AmDrake, "sly", "So I could distract and rob you guys.", flipped : true),
                    new(AmVic, "annoyed", "That's a stupid plan."),
                    new(AmDrake, "reallymad", "Shut up.", flipped : true),
                ]
            }},
            {"Vic_JumboFirstFight_2", new(){
                type = NodeType.@event,
                lookup = ["miner_midcombat"],
                requiredScenes = ["Vic_Drake_Meet_0"],
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
            {"Vic_Max_Meet_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmMax ],
                requiredScenes = ["Vic_BeforeCobalt_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmMax, "You said your name was Garrus?"),
                    new(AmVic, "neutraltalk", "Correct.", flipped: true),
                    new(AmMax, "squint", "How do you have admin access?"),
                    new(AmMax, "squint", "There's no record of you anywhere."),
                    new(AmVic, "neutraltalk", "That information was erased.", flipped: true),
                    new(AmVic, "neutraltalk", "The crew was never supposed to know of my existance.", flipped: true),
                    new(AmVic, "observe", "Outside of Hyperia, that is.", flipped: true),
                    new(AmMax, "squint", "Are you the client she was talking about?"),
                    new(AmVic, "neutraltalk", "No. I was Hyperia's commanding officer.", flipped: true),
                    new(AmVic, "neutraltalk", "I reported to the client.", flipped: true),
                    new(AmMax, "Who was the client?"),
                    new(AmVic, "pensive", "I don't know.", flipped: true),
                ]
            }},
            {"Vic_Max_Meet_1", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmMax ],
                requiredScenes = ["Vic_Max_Meet_0"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmMax, "What even was the point of the project?"),
                    new(AmVic, "neutraltalk", "Time crystal research.", flipped: true),
                    new(AmVic, "neutraltalk", "The client wanted to control space-time.", flipped: true),
                    new(AmVic, "annoyed", "...and promptly found out why that was a bad idea.", flipped: true),
                    new(AmMax, "intense", "Wow."),
                    new(AmMax, "intense", "That's like...galaxy domination level stuff."),
                    new(AmVic, "neutraltalk", "Correct.", flipped: true),
                    new(AmMax, "But..."),
                    new(AmMax, "squint", "...if you knew about this, why take the job?"),
                    new(AmVic, "neutraltalk", "I didn't know.", flipped: true),
                    new(AmVic, "pensive", "Not until it was too late.", flipped: true),
                ]
            }},
            {"Vic_Max_Meet_2", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmMax ],
                requiredScenes = ["Vic_Max_Meet_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmMax, "Hey Garrus. Question."),
                    new(AmVic, "neutraltalk", "Shoot.", flipped: true),
                    new(AmMax, "Why talk about all this stuff?"),
                    new(AmMax, "Didn't you say it was classified?"),
                    new(AmVic, "neutraltalk", "The Cobalt blew up.", flipped: true),
                    new(AmVic, "neutraltalk", "Our contract is terminated.", flipped: true),
                    new(AmMax, "Oh."),
                    new(AmMax, "intense", "...wait, does that mean I'm unemployed?"),
                    new(AmVic, "annoyed", "Yes. As am I.", flipped: true),
                    new(AmMax, "mad", "Damnit. I hate looking for jobs."),
                    new(AmVic, "annoyed", "You and me both.", flipped: true),
                ]
            }},

            {"Vic_Isaac_Meet_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmIsaac ],
                requiredScenes = ["Vic_BeforeCobalt_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmIsaac, "writing", "Replace plating on Chosen One."),
                    new(AmIsaac, "writing", "Isaac Jr. needs circuitry rewired."),
                    new(AmIsaac, "writing", "Maybe rename Battery?"),
                    new(AmVic, "neutraltalk", "Hello? Is the missile bay open?", flipped: true),
                    new(AmIsaac, "shy", "Oh! Um...yes! Come in!"),
                    new(AmVic, "neutraltalk", "Hey there.", flipped: true),
                    new(AmIsaac, "Hi! Are you new?"),
                    new(AmVic, "neutraltalk", "Sort of. You're Isaac, correct?", flipped: true),
                    new(AmIsaac, "Yep!"),
                    new(AmVic, "neutraltalk", "My name is Garrus. Pleasure to meet you.", flipped: true),
                    new(AmVic, "neutraltalk", "Hyperia spoke very highly of you.", flipped: true),
                    new(AmIsaac, "Thanks! What brings you to my humble abode?"),
                    new(AmVic, "observe", "I understand you're our drone expert?", flipped: true),
                    new(AmIsaac, "shy", "You could call me that."),
                    new(AmVic, "pensive", "I...need some assistance. One of my drones isn't working.", flipped: true),
                    new(AmIsaac, "explains", "I'd be happy to help!"),
                ]
            }},


            {"Vic_Isaac_Meet_1", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = true,
                allPresent = [ AmVic, AmIsaac ],
                nonePresent = [AmBooks],
                requiredScenes = ["Vic_Isaac_Meet_0"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmIsaac, "Shield drones are easier to deploy."),
                    new(AmVic, "neutraltalk", "Mobility is everything. Engine Boosters are better.", flipped: true),
                    new(AmIsaac, "Attack Drone beats Shift Drone."),
                    new(AmVic, "observe", "I'll concede that.", flipped: true),
                    new(AmCat, "What are you guys talking about?"),
                    new(AmIsaac, "sly", "Drones."),
                    new(AmVic, "explains", "The midrow.", flipped: true),
                    new(AmCat, "worried", "...okay?"),
                    new(AmIsaac, "Asteroids beat missiles."),
                    new(AmVic, "pda", "What about space mines?", flipped: true),
                    new(AmBooks, "paws", "Geodes beat them both!", flipped: true),
                    new(AmVic, "pressuredstatic", "...", flipped: true),
                    new(AmIsaac, "gameover", "..."),
                    new(AmVic, "pressured", "...where did you even come from?", flipped: true),
                    new(AmBooks, "crystal", "Crystals let me travel through time and space!", flipped: true),
                    new(AmBooks, "blush", "Watch me teleport!", flipped: true),
                    new(AmVic, "pressuredstatic", "...", flipped: true),
                    new(AmIsaac, "gameover", "..."),
                    new(AmVic, "observe", "Draw?", flipped: true),
                    new(AmIsaac, "shy", "Deal."),
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}