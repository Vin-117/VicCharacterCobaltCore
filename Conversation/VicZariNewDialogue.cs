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

internal class VicZariNewDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", "TeraTheTaxCollector", new Dictionary<string, DialogueMachine>(){
            {"VicNukeLaunchZari_0", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmZari ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmZari, "worried", "That missile reeks of death."),
                  new(AmVic, "pensive", "Yes it does.")
                ]
            }},
            {"VicBiggerNukeLaunchZari_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmZari ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmZari, "worried", "Are you mad?!"),
                  new(AmVic, "pensive", "Perhaps.")
                ]
            }},

            {"VicSeekerSwarmLaunchZari_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmZari ],
                oncePerRun = true,
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicMidrowYap" ],
                oncePerRunTags = ["ZariDoesNotLikeSeekers"],
                oncePerCombat = true,
                dialogue = [
                  new(AmZari, "arrogant", "Seeking bolts? Crude."),
                  new(AmVic, "annoyed", "When did you care about fighting fair?"),
                ]
            }},

            {"VicSeekerSwarmLaunchBackZari_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmZari ],
                oncePerRun = true,
                lookup = [ "VicSeekerSwarmBack" ],
                anyDronesHostile = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicMidrowYap" ],
                dialogue = [
                  new(AmZari, "annoyed", "Your missiles are committing mutiny."),
                  new(AmVic, "pressured", "I know, I know."),
                ]
            }},

            {"VicHeavySeekerSwarmLaunch_Zari_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmZari ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicMidrowYap" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pdasmile", "Heavy seekers online."),
                  new(AmZari, "annoyed", "You are such a braggart.")
                ]
            }},

            {"VicWentMissing_Zari_0", new(){
                type = NodeType.combat,
                allPresent = [ AmZari ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmZari, "arrogant", "Garrus is gone? Pity.")
                ]
            }},

            {"AquiredVicLevelheaded_Zari_2", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicLevelheaded" ],
                allPresent = [ AmVic, AmZari ],
                hasArtifactTypes = [typeof(VicLevelheaded)],
                dialogue = [
                    new(AmZari, "pondering", "You dabble in the occult? Curious."),
                    new(AmVic, "pressured", "What are you talking about?")
                ]
            }},

            {"JustHitVic_ZariMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmZari ],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmZari, "arrogant", "So you DO have an aggressive side."),
                    new(AmVic, "annoyed", "You're not goading me into it.")
                ]
            }},

            {"JustHitZari_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                priority = true,
                oncePerCombatTags = [ "ZariHitEmYo" ],
                allPresent = [ AmVic, AmZari ],
                playerShotJustHit = true,
                whoDidThatName = AmZari,
                minDamageDealtToEnemyThisAction = 3,
                dialogue = [
                    new(AmVic, "neutraltalk", "Good shot."),
                    new(AmZari, "explains", "Why thank you!")
                ]
            }},

            {"VicZariEngineBoosterLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmZari ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicMidrowYap" ],
                oncePerCombat = true,
                dialogue = [
                    new(AmZari, "arrogant", "Trying to mimic my flight?"),
                    new(AmVic, "annoyed", "This isn't a competition, Zari.")
                ]
            }},


            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}