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
             {"JustHitRiggs_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmRiggs ],
                playerShotJustHit = true,
                whoDidThat = Deck.riggs,
                minDamageDealtToEnemyThisAction = 8,
                dialogue = [
                    new(AmVic, "pressured", "Where did you get that gun?"),
                    new(AmRiggs, "gun", "Don't worry about it!")
                ]
            }},
             {"JustHitIsaac_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmIsaac ],
                playerShotJustHit = true,
                whoDidThat = Deck.goat,
                minDamageDealtToEnemyThisAction = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Good shot there, Isaac."),
                    new(AmIsaac, "Thanks!")
                ]
            }},
             {"JustHitDrake_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmDrake ],
                playerShotJustHit = true,
                whoDidThat = Deck.eunice,
                minDamageDealtToEnemyThisAction = 4,
                dialogue = [
                    new(AmVic, "annoyed", "I suppose that was good enough."),
                    new(AmDrake, "sly", "You know you love me, gramps.")
                ]
            }},
             {"JustHitMax_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmMax ],
                playerShotJustHit = true,
                whoDidThat = Deck.hacker,
                minDamageDealtToEnemyThisAction = 2,
                dialogue = [
                    new(AmVic, "neutraltalk", "That was a good shot, Max."),
                    new(AmDrake, "smile", "Thanks man.")
                ]
            }},
             {"JustHitBooks_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmBooks ],
                playerShotJustHit = true,
                whoDidThat = Deck.shard,
                minDamageDealtToEnemyThisAction = 3,
                dialogue = [
                    new(AmVic, "observe", "For a kid, you're good with a gun."),
                    new(AmBooks, "squint", "I'm not a kid!!!")
                ]
            }},
             {"JustHitCat_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmCat ],
                playerShotJustHit = true,
                whoDidThat = Deck.colorless,
                minDamageDealtToEnemyThisAction = 3,
                dialogue = [
                    new(AmVic, "neutraltalk", "Excellent shot as always, Cat."),
                    new(AmCat, "smug", "You know it!")
                ]
            }},
             {"JustHitVic_PeriMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmPeri ],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmPeri, "Excellent shot, sir."),
                    new(AmVic, "explains", "A little calibration goes a long way.")
                ]
            }},
             {"JustHitVic_DrakeMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDrake ],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmDrake, "...Okay, that was pretty good."),
                    new(AmVic, "annoyed", "See what happens when you don't abuse the heatsinks?")
                ]
            }},
             {"JustHitVic_MaxMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmMax ],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmMax, "Eyyy, good one."),
                    new(AmVic, "happyneutral", "All in a days work!")
                ]
            }},

             {"StardogGetsChatty_Multi_Vic", new(){
                type = NodeType.combat,
                allPresent = [AmVic, AmStardog],
                hasArtifacts = ["CargoHold"],
                turnStart = true,
                oncePerCombatTags = [ "StardogLeaveUsAlone" ],
                dialogue = [
                    new(AmStardog, "Only one missile bay? Pathetic."),
                    new(AmVic, "determined", "I only need one to take you down."),
                ]
            }},

             {"StardogGetsChatty_Multi_Vic2", new(){
                type = NodeType.combat,
                allPresent = [AmVic, AmStardog],
                hasArtifacts = ["ControlRods"],
                turnStart = true,
                oncePerCombatTags = [ "StardogLeaveUsAlone" ],
                dialogue = [
                    new(AmStardog, "Only one missile bay? Pathetic."),
                    new(AmVic, "determined", "I only need one to take you down."),
                ]
            }},

             {"StardogGetsHumbled_Multi_Vic", new(){
                type = NodeType.combat,
                allPresent = [AmVic, AmStardog],
                lookup = [ "VicMisdirection" ],
                oncePerCombat = true,
                dialogue = [
                    new(AmStardog, "panic", "Uh..."),
                    new(AmVic, "smug", "Regretting the three missile bays now?"),
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

             {"Vic_AboutToDieAndLoop_Dizzy_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDizzy ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmDizzy, "squint", "This looks like a lost timeline."),
                    new(AmVic, "determined", "Don't you start giving up now.")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Peri_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmPeri ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "determined", "Fight to the last breath!"),
                    new(AmPeri, "vengeful", "Yes sir!")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Riggs_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmRiggs ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmRiggs, "banana", "Anyone want a banana before we die?"),
                    new(AmVic, "annoyed", "...Sure.")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Isaac_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmIsaac, "squint", "...Is it over, Garrus?"),
                    new(AmVic, "pensive", "I'm sorry, Isaac.")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Drake_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDrake ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmDrake, "squint", "Seriously? We die here?"),
                    new(AmVic, "annoyed", "This wouldn't have happened if you were less reckless.")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Max_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmMax ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmMax, "intense", "Game over man!"),
                    new(AmVic, "determined", "Don't log off just yet.")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Books_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmBooks ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmBooks, "plan", "We can still do this! Just believe!"),
                    new(AmVic, "pensive", "You've got a good heart, kid.")
                ]
            }},

             {"Vic_AboutToDieAndLoop_Cat_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmCat ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "annoyed", "Well, this was a disappointment."),
                    new(AmCat, "grumpy", "Were you always so jaded?"),
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}