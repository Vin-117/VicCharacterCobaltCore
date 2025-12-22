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

internal class VicJohnsonNewDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", "Shockah.Johnson", new Dictionary<string, DialogueMachine>(){
            {"VicNukeLaunchJohnson_0", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmJohnson ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmJohnson, "Where did you source such dangerous material?"),
                  new(AmVic, "neutraltalk", "It's better if you don't know.")
                ]
            }},
            {"VicBiggerNukeLaunchJohnson_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmJohnson, "fiddling", "This is too scorched earth for my taste."),
                  new(AmVic, "pensive", "Sorry. But not sorry.")
                ]
            }},

            {"Vic_AboutToDieAndLoop_Johnson_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmJohnson, "fiddling", "Well, are we clear to declare bankruptcy?"),
                    new(AmVic, "annoyed", "Do you talk in anything other than corporate lingo?")
                ]
            }},

            {"Vic_AboutToDieAndLoop_Johnson_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "annoyed", "Well, this run didn't pay off."),
                    new(AmJohnson, "It was a risky investment, certainly."),
                ]
            }},

            {"JustHitVic_JohnsonMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmJohnson, "I see you know how to make an impact."),
                    new(AmVic, "neutraltalk", "You could say that.")
                ]
            }},

            {"VicJohnsonSatelliteLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRun = true,
                oncePerCombat = true,
                dialogue = [
                  new(AmJohnson, "flashing", "Ah. A good wifi connection to check my investments."),
                  new(AmVic, "annoyed", "Are you seriously doing this in the middle of a fight?"),
                ]
            }},

            {"VicJohnsonSatelliteLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRun = true,
                oncePerCombat = true,
                dialogue = [
                  new(AmJohnson, "This data will let me run a proper linear regression model."),
                  new(AmVic, "pda", "It’ll do a lot more than that."),
                ]
            }},

            {"VicJohnsonSatelliteUpgradedLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRun = true,
                oncePerCombat = true,
                dialogue = [
                  new(AmJohnson, "flashing", "With all this data, I'll be ahead of the market."),
                  new(AmVic, "annoyed", "Start browsing and I’ll terminate your connection.")
                ]
            }},

            {"VicJohnsonBarrierLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                oncePerRunTags = ["CrewYapAboutBarrier"],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                    new(AmJohnson, "Let's hope that investment pays off."),
                    new(AmVic, "pda", "Don't worry, it will.")
                ]
            }},

            {"TookDamage_VicJohnson_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmJohnson ],
                enemyShotJustHit = true,
                oncePerRun = true,
                minDamageDealtToPlayerThisTurn = 2,
                dialogue = [
                    new(AmJohnson, "squint", "Alright. Enough is enough. I’m contacting security."),
                    new(AmVic, "doubtful", "What does it look like I'm doing?")
                ]
            }},

            {"JustHitJohnson_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                oncePerCombatTags = [ "JohnsonHitEmYo" ],
                allPresent = [ AmVic, AmJohnson ],
                playerShotJustHit = true,
                whoDidThatName = AmJohnson,
                minDamageDealtToEnemyThisAction = 2,
                dialogue = [
                    new(AmVic, "neutraltalk", "Excellent shot."),
                    new(AmJohnson, "Thank you.")
                ]
            }},

            {"JustHitJohnson_VicMulti_1", new(){
                type = NodeType.combat,
                oncePerRun = true,
                oncePerCombatTags = [ "JohnsonHitEmYo" ],
                allPresent = [ AmVic, AmJohnson ],
                playerShotJustHit = true,
                whoDidThatName = AmJohnson,
                minDamageDealtToEnemyThisAction = 2,
                dialogue = [
                    new(AmVic, "pda", "High impact confirmed."),
                    new(AmJohnson, "fiddling", "Do you mind submitting that as a formal recommendation?")
                ]
            }},

            {"AquiredFrugality_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                allPresent = [ AmVic, AmJohnson ],
                hasArtifacts = [JohnsonFrugal],
                dialogue = [
                    new(AmVic, "doubtful", "Saving money? That's meaningless here."),
                    new(AmJohnson, "flashing", "Increasing your net worth is always the correct choice."),
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}