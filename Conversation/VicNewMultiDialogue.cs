using FMOD;
using Microsoft.Xna.Framework.Graphics;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using System.Linq;
using VicCharacter.Artifacts;
using VicCharacter.External;
using static VicCharacter.Conversation.CommonDefinitions;

namespace VicCharacter.Conversation;

internal class VicNewMultiDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", new Dictionary<string, DialogueMachine>(){
            {"AquiredPrototype22_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "Prototype22" ],
                allPresent = [ AmVic, AmDizzy ],
                hasArtifacts = [ "Prototype22" ],
                dialogue = [
                    new(AmVic, "observe", "Are you sure this shield generator is stable?"),
                    new(AmDizzy, "explains", "Stable is a relative term."),
                ]
            }},
            {"AquiredPowerDiverson_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "PowerDiversion" ],
                allPresent = [ AmVic, AmPeri ],
                hasArtifacts = [ "PowerDiversion" ],
                dialogue = [
                    new(AmVic, "smug", "Give 'em hell, Hyperia."),
                    new(AmPeri, "vengeful", "Yessir."),
                ]
            }},
             {"AquiredRadioRepeater_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "RadioRepeater" ],
                allPresent = [ AmVic, AmIsaac ],
                hasArtifacts = [ "RadioRepeater" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Do you think your repeater will work on my drones?"),
                    new(AmIsaac, "explains", "Positive. Give it a try!"),
                ]
            }},
             {"AquiredThermoReactor_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "ThermoReactor" ],
                allPresent = [ AmVic, AmDrake ],
                hasArtifacts = [ "ThermoReactor" ],
                dialogue = [
                    new(AmVic, "observe", "Not sure if I'd take the heat over dirtier engines."),
                    new(AmDrake, "mad", "This engine is so much better than that hunk of garbage."),
                ]
            }},
             {"AquiredTridimensionalCockpit_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "TridimensionalCockpit" ],
                allPresent = [ AmVic, AmMax ],
                hasArtifacts = [ "TridimensionalCockpit" ],
                dialogue = [
                    new(AmVic, "observe", "The cockpit is...different."),
                    new(AmMax, "neutral", "I don't really know either, man."),
                ]
            }},
             {"AquiredSummonControl_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "SummonControl" ],
                allPresent = [ AmVic, AmCat ],
                hasArtifacts = [ "SummonControl" ],
                dialogue = [
                    new(AmVic, "pressuredneutral", "Your adaptability is astounding, Cat."),
                    new(AmCat, "smug", "That's why I'm here!"),
                ]
            }},
             {"AquiredVicLevelheaded_Vic_1", new(){
                type = NodeType.combat,
                 priority = true,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicLevelheaded" ],
                allPresent = [ AmVic, AmBooks ],
                hasArtifactTypes = [typeof(VicLevelheaded)],
                dialogue = [
                    new(AmBooks, "paws", "Garrus! Garrus! Do you believe in ghosts?"),
                    new(AmVic, "pressuredneutral", "What?! Of course not!")
                ]
            }},
             {"AquiredVicLevelheaded_Vic_2", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicLevelheaded" ],
                allPresent = [ AmVic, AmMax ],
                hasArtifactTypes = [typeof(VicLevelheaded)],
                dialogue = [
                    new(AmMax, "neutral", "You look a little haunted, man."),
                    new(AmVic, "pressuredneutral", "I have no idea what you're talking about.")
                ]
            }},
             {"AquiredVicLevelheaded_Vic_3", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicLevelheaded" ],
                allPresent = [ AmVic, AmCat ],
                hasArtifactTypes =[typeof(VicLevelheaded)],
                dialogue = [
                    new(AmCat, "worried", "I'm detecting strange energy signatures near you, Garrus."),
                    new(AmVic, "pressuredneutral", "Ghosts? Don't be ridiculous.")
                ]
            }},
             {"AquiredOverclockedMissileBay_VicMulti0", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicOverclockedMissileBay" ],
                allPresent = [ AmVic, AmIsaac ],
                hasArtifactTypes = [typeof(VicOverclockedMissileBay)],
                dialogue = [
                    new(AmIsaac, "shy", "Uh...Garrus? The missile bay is..."),
                    new(AmVic, "pdapressured", "I know. I'm working on it.")
                ]
            }},
             {"VicNukeLaunchMulti_0", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "panic", "Is that a nuke?!"),
                  new(AmVic, "neutraltalk", "Yes.")
                ]
            }},
             {"VicNukeLaunchMulti_1", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmPeri ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmPeri, "panic", "...Isn't that a little excessive, sir?"),
                  new(AmVic, "pressuredneutral", "Possibly.")
                ]
            }},
             {"VicNukeLaunchMulti_2", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmDrake ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmDrake, "panic", "Ok, maybe I underestimated you."),
                  new(AmVic, "annoyed", "You're only realizing that now?")
                ]
            }},
             {"VicNukeLaunchMulti_3", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmBooks ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmBooks, "paws", "Garrus! Garrus! What does that missile do?"),
                  new(AmVic, "panic", "It...well...")
                ]
            }},
             {"VicNukeLaunchMulti_4", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmCat ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmCat, "squint", "Where did you get enough uranium for that?"),
                  new(AmVic, "neutraltalk", "Don't ask.")
                ]
            }},
             {"VicNukeLaunchMulti_5", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmDizzy ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmDizzy, "geiger", "Oh hey! My geiger counter is going off!"),
                  new(AmVic, "panic", "That's not a good thing.")
                ]
            }},
             {"VicBiggerNukeLaunchMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "panic", "Is that a BIGGER nuke?"),
                  new(AmVic, "pensive", "Yes.")
                ]
            }},
             {"VicBiggerNukeLaunchMulti_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmPeri ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmPeri, "panic", "...That's definitely excessive force, sir."),
                  new(AmVic, "pensive", "Yes. Yes it is.")
                ]
            }},
             {"VicBiggerNukeLaunchMulti_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDrake ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmDrake, "panic", "I...wha..."),
                  new(AmVic, "annoyed", "I warned you not to underestimate me.")
                ]
            }},
             {"VicBiggerNukeLaunchMulti_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmBooks ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmBooks, "stoked", "Wow! This missile even has a skull on it!"),
                  new(AmVic, "pressuredneutral", "...You may want to cover your eyes, kiddo.")
                ]
            }},
             {"VicBiggerNukeLaunchMulti_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmCat ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmCat, "worried", "We're going to be irradiated with a payload that big."),
                  new(AmVic, "pensive", "I know.")
                ]
            }},
             {"VicBiggerNukeLaunchMulti_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDizzy ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmDizzy, "intense", "...Wait a second. Is that a nuclear bomb?"),
                  new(AmVic, "annoyed", "You're only realizing now?")
                ]
            }},
             {"JustHitPeri_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                oncePerCombatTags = [ "PeriHitEmYo" ],
                allPresent = [ AmVic, AmPeri ],
                playerShotJustHit = true,
                whoDidThat = Deck.peri,
                minDamageDealtToEnemyThisAction = 3,
                dialogue = [
                    new(AmVic, "neutraltalk", "Excellent shot, Hyperia."),
                    new(AmPeri, "nap", "Thank you, sir.")
                ]
            }},
             {"JustHitDizzy_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                hasArtifacts = [ "DizzyBoost" ],
                allPresent = [ AmVic, AmDizzy ],
                playerShotJustHit = true,
                whoDidThat = Deck.dizzy,
                minDamageDealtToEnemyThisAction = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Fine work there, Dizzy."),
                    new(AmDizzy, "explains", "This photon condenser really makes the difference.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAll_VicMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmRiggs ],
                priority = true,
                shipsDontOverlapAtAll = true,
                nonePresent = [ "crab", "scrap" ],
                oncePerRun = true,
                oncePerCombatTags = [ "NoOverlapBetweenShips" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Great work, Riggs."),
                    new(AmRiggs, "I do my best!")
                ]
            }},
            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}