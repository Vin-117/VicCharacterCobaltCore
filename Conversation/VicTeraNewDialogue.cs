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

internal class VicTeraNewDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", "TeraTheTaxCollector", new Dictionary<string, DialogueMachine>(){
            {"VicNukeLaunchTera_0", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmTera ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmTera, "scared", "I-Is that a nuclear bomb?!"),
                  new(AmVic, "neutraltalk", "Yes.")
                ]
            }},
            {"VicBiggerNukeLaunchTera_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmTera ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmTera, "sad", "I-Is that a B-bIGGER nuclear bomb?!"),
                  new(AmVic, "pensive", "Yes.")
                ]
            }},

            {"VicSeekerSwarmLaunchTera_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmTera ],
                oncePerRun = true,
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicMidrowYap" ],
                dialogue = [
                  new(AmVic, "observe", "Are missiles a tax write off?"),
                  new(AmTera, "squint", "...No.")
                ]
            }},

            {"VicSeekerSwarmLaunchBackTera_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmTera ],
                oncePerRun = true,
                lookup = [ "VicSeekerSwarmBack" ],
                anyDronesHostile = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicMidrowYap" ],
                dialogue = [
                    new(AmTera, "lookawaynervous", "W-Why is that missile aiming at us?"), 
                    new(AmVic, "pensive", "I screwed up."),
                ]
            }},

            {"VicHeavySeekerSwarmLaunch_Tera_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmTera ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicMidrowYap" ],
                oncePerRun = true,
                dialogue = [
                  new(AmTera, "scared", "What are those missiles?"),
                  new(AmZari, "pdasmile", "Better seekers.")
                ]
            }},

            {"VicWentMissing_Tera_0", new(){
                type = NodeType.combat,
                allPresent = [ AmTera ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmTera, "lookawaynervous", "Where did G-Garrus go?")
                ]
            }},

            {"AquiredOverclockedMissileBay_VicTera", new(){
                type = NodeType.combat,
                priority = false,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicOverclockedMissileBay" ],
                allPresent = [ AmVic, AmTera ],
                hasArtifactTypes = [typeof(VicOverclockedMissileBay)],
                dialogue = [
                    new(AmTera, "lookawaynervous", "What did y-you do to the missile bay?"),
                    new(AmVic, "pressured", "Don't worry about it.")
                ]
            }},

            {"JustHitVic_TeraMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmTera ],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmTera, "happy", "Great shot!"),
                    new(AmVic, "happyneutral", "Only the best!")
                ]
            }},

            {"JustHitTera_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                priority = true,
                oncePerCombatTags = [ "TeraHitEmYo" ],
                allPresent = [ AmVic, AmTera ],
                playerShotJustHit = true,
                whoDidThatName = AmTera,
                minDamageDealtToEnemyThisAction = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Good shot, Tera."),
                    new(AmZari, "happy", "Thanks!")
                ]
            }},

            {"Vic_AboutToDieAndLoop_Tera_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmTera ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "pensive", "It might be over for us."),
                    new(AmTera, "lookawaynervous", "W-wait! You're giving up already?"),
                ]
            }},

            {"Vic_Tera_Meet_0", new(){
                type = NodeType.@event,
                lookup = [ "zone_first" ],
                once = false,
                allPresent = [ AmVic, AmTera ],
                requiredScenes = ["Vic_BeforeCobalt_1"],
                bg = "BGRunStart",
                dialogue = [
                    new(AmTera, "H-hello? Anyone at the bridge?"),
                    new(AmTera, "..."),
                    new(AmTera, "Guess I'm early again."),
                    new(AmVic, "determined", "Not so fast.", flipped: true),
                    new(AmVic, "determined", "Who are you? I know you're not a member of the crew.", flipped: true),
                    new(AmTera, "scared", "A-aah!"),
                    new(AmTera, "lookawaynervous", "How long were you standing there?"),
                    new(AmVic, "determined", "Long enough. Now answer the question.", flipped: true),
                    new(AmVic, "determined", "Who are you?", flipped: true),
                    new(AmTera, "lookawaynervous", "I...I'm Tera. I'm a tax collector."),
                    new(AmVic, "pressuredneutral", "A tax collector?", flipped: true),
                    new(AmVic, "observe", "Well, that would explain the documents.", flipped: true),
                    new(AmTera, "lookawaynervous", "You were going through my things?"),
                    new(AmVic, "neutraltalk", "No. Just glanced at a few 1040s you dropped in the hall.", flipped: true),
                    new(AmVic, "annoyed", "Speaking of, please clean those up.", flipped: true),
                    new(AmTera, "lookawaynervous", "Oh, uh...s-sorry. I'll get to that."),
                    new(AmVic, "neutraltalk", "Thank you.", flipped: true),
                    new(AmVic, "neutraltalk", "Now, can you handle yourself in a fight?", flipped: true),
                    new(AmVic, "neutraltalk", "There's a ship nearby powering up its weapons.", flipped: true),
                    new(AmTera, "lookawaynervous", ""),

                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}