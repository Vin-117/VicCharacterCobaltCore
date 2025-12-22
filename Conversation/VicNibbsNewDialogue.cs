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

internal class VicNibbsNewDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", "TheJazMaster.Nibbs", new Dictionary<string, DialogueMachine>(){
            {"VicNukeLaunchNibbs_0", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBigNukeMulti"],
                allPresent = [ AmVic, AmNibbs ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmNibbs, "squint", "That rocket smells funny."),
                  new(AmVic, "pressured", "Were you sniffing it?")
                ]
            }},

            {"VicBiggerNukeLaunchNibbs_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmNibbs ],
                priority = true,
                oncePerRun = true,
                oncePerRunTags = ["VicBiggerNukeMulti"],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmNibbs, "wowza", "New rocket? Gimme gimme!"),
                  new(AmVic, "pressured", "Don't touch that. Seriously.")
                ]
            }},

            {"EnemyGainedDodge_VicNibbs_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmNibbs ],
                oncePerCombatTags = [ "aboutAutododge" ],
                lastTurnEnemyStatuses = [ Status.autododgeLeft ],
                dialogue = [
                    new(AmVic, "smug", "Autododge? Nothing a seeker couldn't fix."),
                    new(AmNibbs, "squint", "Hey! That's cheating!"),
                ]
            }},

            {"EnemyGainedDodge_VicNibbs_1", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic, AmNibbs ],
                oncePerCombatTags = [ "aboutAutododge" ],
                lastTurnEnemyStatuses = [ Status.autododgeRight ],
                dialogue = [
                    new(AmVic, "smug", "Autododge? Nothing a seeker couldn't fix."),
                    new(AmNibbs, "squint", "Hey! That's cheating!"),
                ]
            }},

            {"VicSeekerSwarmLaunchNibbs_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmNibbs ],
                oncePerRun = true,
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerRunTags = ["NibbsDoesNotLikeSeekers"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Seekers deployed."),
                  new(AmNibbs, "Wow! Are we cheating now too?")
                ]
            }},

            {"VicSeekerSwarmLaunchNibbs_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmNibbs ],
                oncePerRun = true,
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerRunTags = ["NibbsDoesNotLikeSeekers"],
                oncePerCombat = true,
                dialogue = [
                  new(AmNibbs, "squint", "Rockets? That's cheating!"),
                  new(AmVic, "neutraltalk", "All's fair in love and war."),
                ]
            }},

            {"Vic_AboutToDieAndLoop_Nibbs_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmNibbs ],
                enemyShotJustHit = true,
                maxHull = 2,
                oncePerCombatTags = ["aboutToDie"],
                oncePerRun = true,
                dialogue = [
                    new(AmNibbs, "serious", "Are we gonna explode?"),
                    new(AmVic, "determined", "Not if I can help it.")
                ]
            }},

            {"JustHitVic_NibbsMulti_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmNibbs ],
                lookup = [ "VicThanix" ],
                oncePerRunTags = ["NibbsComplimentsVic"],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmNibbs, "Rawr, big attack!"),
                    new(AmVic, "explains", "If it isn’t big, you shouldn’t bother.")
                ]
            }},

            {"JustHitVic_NibbsMulti_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmNibbs ],
                oncePerRunTags = ["NibbsComplimentsVic"],
                lookup = [ "VicThanix" ],
                oncePerCombatTags = [ "VicGetsComplimented" ],
                minDamageDealtToEnemyThisAction = 3,
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "pda", "Got a clean shot off."),
                    new(AmNibbs, "squint", "Clean? Are all my shots dirty?"),
                ]
            }},

            {"ThatsALotOfDamageToThem_VicNibbs_0", new(){
                type = NodeType.combat,
                playerShotJustHit = true,
                minDamageDealtToEnemyThisTurn = 10,
                allPresent = [ AmVic, AmNibbs ],
                dialogue = [
                    new(AmNibbs, "wowza", "Nibbs will smash all the things!!!"),
                    new(AmVic, "pressured", "...Let’s try not to not destroy the central command console.")
                ]
            }},

            {"WeGotShotButTookNoDamage_VicNibbs_0", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                oncePerRun = true,
                maxDamageDealtToPlayerThisTurn = 0,
                oncePerCombatTags = [ "VicTookNoDMGOnce" ],
                oncePerCombat = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Good block."),
                    new(AmNibbs, "Blocking is boring!")
                ]
            }},

            {"JustHitNibbs_VicMulti_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                oncePerCombatTags = [ "NibbsHitEmYo" ],
                allPresent = [ AmVic, AmNibbs ],
                playerShotJustHit = true,
                //whoDidThat = NibbsDeck,
                minDamageDealtToEnemyThisAction = 2,
                dialogue = [
                    new(AmNibbs, "cheeky", "Nya! I got ‘em!"),
                    new(AmVic, "happyneutral", "You certainly did, Nibbs.")
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}