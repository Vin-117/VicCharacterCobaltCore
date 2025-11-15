using FMOD;
using Microsoft.Xna.Framework.Graphics;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using VicCharacter.Artifacts;
using VicCharacter.External;
using static VicCharacter.Conversation.CommonDefinitions;

namespace VicCharacter.Conversation;

internal class VicNewCombatDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", new Dictionary<string, DialogueMachine>(){
            {"VicRemember_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "All these loops...all these memories...")
                ]
            }},
            {"VicRemember_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "...How long have we been here? How long have we been alive?")
                ]
            }},
            {"VicRemember_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "Will life be the same when we escape? If we escape?")
                ]
            }},
            {"VicRemember_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "Does any of it matter? Will any of this be remembered?")
                ]
            }},
            {"VicRemember_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "I remember it so clearly. And yet, it blurs together...")
                ]
            }},
            {"VicRemember_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "...Is this truly endless? Will we truly be here forever?")
                ]
            }},
            {"VicRemember_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "Who are we anymore? Are we still the same as before the loop?")
                ]
            }},
            {"VicRemember_7", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pressured", "...I almost don't want to remember. To be blissfully ignorant...")
                ]
            }},
            {"VicSeekerSwarmLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "I have you now.")
                ]
            }},
            {"VicSeekerSwarmLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "Just try and dodge this.")
                ]
            }},
            {"VicSeekerSwarmLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Seekers locked.")
                ]
            }},
            {"VicSeekerSwarmLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "I never miss.")
                ]
            }},
            {"VicSeekerSwarmLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                anyDrones = [ "missile_seeker" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Missile targets confirmed.")
                ]
            }},
            {"VicEngineBoosterLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "This'll put a kick in our engines.")
                ]
            }},
            {"VicEngineBoosterLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Our thrusters aren't mobile enough. Let's change that.")
                ]
            }},
            {"VicEngineBoosterLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "We need a boost. And I know how to get it.")
                ]
            }},
            {"VicEngineBoosterLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Try to keep this alive. You'll thank me later.")
                ]
            }},
            {"VicEngineBoosterLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Give it enough time, and we'll fly circles around them.")
                ]
            }},
            {"VicEngineBoosterLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Mind that drone. They take a while to replace.")
                ]
            }},
            {"VicEngineBoosterLaunch_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Watch our thruster output. It'll jump when that drone fires.")
                ]
            }},
            {"VicSatelliteLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Patching into our satellite array now.")
                ]
            }},
            {"VicSatelliteLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Launching a sensor array.")
                ]
            }},
            {"VicSatelliteLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Even if it just blocks a shot, that's fine.")
                ]
            }},
            {"VicSatelliteLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Scanning system online.")
                ]
            }},
            {"VicSatelliteLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Uploading logistical data to the bridge now.")
                ]
            }},
            {"VicSatelliteUpgradedLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "There's no such thing as too much intel.")
                ]
            }},
            {"VicSatelliteUpgradedLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "Proper combat data. Finally.")
                ]
            }},
            {"VicSatelliteUpgradedLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "Double the output, twice the effectiveness.")
                ]
            }},
            {"VicSatelliteUpgradedLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Never settle for less when you can have more.")
                ]
            }},
            {"VicSatelliteUpgradedLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "You might need a second monitor for all this data.")
                ]
            }},
            {"VicBarrierLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "determined", "This is where they'll stop.")
                ]
            }},
            {"VicBarrierLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Don't shoot this. Trust me.")
                ]
            }},
            {"VicBarrierLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "High reflect barrier in play.")
                ]
            }},
            {"VicBarrierLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "observe", "Unconventional shielding, but effective.")
                ]
            }},
            {"VicBarrierLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Field has stabilized. They won't get past it now.")
                ]
            }},
             {"VicNukeLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicNuke" ],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                anyDrones = ["VicHURT"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Speak softly and carry a big stick.")
                ]
            }},
             {"VicNukeLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicNuke" ],
                anyDrones = ["VicHURT"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pensive", "Goodbye.")
                ]
            }},
             {"VicNukeLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicNuke" ],
                anyDrones = ["VicHURT"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pensive", "Sorry. But not sorry.")
                ]
            }},
             {"VicNukeLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicNuke" ],
                anyDrones = ["VicHURT"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdapressured", "...Nuclear payload deployed.")
                ]
            }},
             {"VicBiggerNukeLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pensive", "The end.")
                ]
            }},
             {"VicBiggerNukeLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pensive", "Goodbye. And so long.")
                ]
            }},
             {"VicBiggerNukeLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdapressured", "...Final launch trajectory confirmed.")
                ]
            }},
             {"VicBiggerNukeLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicBigNuke" ],
                anyDrones = ["VicPAIN"],
                oncePerCombatTags = [ "VicBigNukeOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pensive", "Sorry about this.")
                ]
            }},
            {"WeMissedOopsie_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "neutral", "Negative impact.")
                ]
            }},
            {"WeMissedOopsie_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "neutraltalk", "Shot failed to connect.")
                ]
            }},
            {"WeMissedOopsie_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "annoyed", "A seeker would've done the job better.")
                ]
            }},
            {"WeMissedOopsie_Vic_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "annoyed", "We don't have unlimited ammo, you know.")
                ]
            }},
            {"WeMissedOopsie_Vic_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "neutraltalk", "This is why we need a recalibrator.")
                ]
            }},
             {"WeGotShotButTookNoDamage_Vic_0", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                maxDamageDealtToPlayerThisTurn = 0,
                oncePerCombatTags = [ "VicTookNoDMGOnce" ],
                oncePerCombat = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Enemy shots hit. Negative damage.")
                ]
            }},
             {"WeGotShotButTookNoDamage_Vic_1", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                maxDamageDealtToPlayerThisTurn = 0,
                lastTurnPlayerStatuses = [Status.shield],
                oncePerCombat = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Shields deflected all damage.")
                ]
            }},
             {"WeGotShotButTookNoDamage_Vic_2", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                maxDamageDealtToPlayerThisTurn = 0,
                lastTurnPlayerStatuses = [Status.tempShield],
                oncePerCombat = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "happyneutral", "Excellent use of temporary shielding.")
                ]
            }},
             {"WeGotShotButTookNoDamage_Vic_3", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                maxDamageDealtToPlayerThisTurn = 0,
                oncePerCombatTags = [ "VicTookNoDMGOnce" ],
                oncePerCombat = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "happy", "Hull untouched.")
                ]
            }},
             {"WeGotShotButTookNoDamage_Vic_4", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                maxDamageDealtToPlayerThisTurn = 0,
                oncePerCombatTags = [ "VicTookNoDMGOnce" ],
                oncePerCombat = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Enemy attacks ineffective.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAll_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                nonePresent = [ "crab", "scrap" ],
                oncePerCombat = true,
                oncePerCombatTags = [ "NoOverlapBetweenShips" ],
                dialogue = [
                    new(AmVic, "happy", "Line of fire: avoided.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAll_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                nonePresent = [ "crab", "scrap" ],
                oncePerCombat = true,
                oncePerCombatTags = [ "NoOverlapBetweenShips" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "It'll take them a moment to get another lock on us.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAll_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                nonePresent = [ "crab", "scrap" ],
                oncePerCombat = true,
                oncePerCombatTags = [ "NoOverlapBetweenShips" ],
                dialogue = [
                    new(AmVic, "happyneutral", "Excellent evasive maneuvers.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAll_Vic_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                nonePresent = [ "crab", "scrap" ],
                oncePerCombat = true,
                oncePerCombatTags = [ "NoOverlapBetweenShips" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Now would be a good time to launch a seeker.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAllButWeDoHaveASeekerToDealWith_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                doesNotHaveArtifacts = ["ChaffEmitters"],
                oncePerCombatTags = [ "NoOverlapBetweenShipsSeeker"],
                anyDronesHostile = [ "missile_seeker" ],
                nonePresent = [ "crab" ],
                dialogue = [
                    new(AmVic, "observe", "...Seems they're using my own tactics against us.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAllButWeDoHaveASeekerToDealWith_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                doesNotHaveArtifacts = ["ChaffEmitters"],
                oncePerCombatTags = [ "NoOverlapBetweenShipsSeeker"],
                anyDronesHostile = [ "missile_seeker" ],
                nonePresent = [ "crab" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Evasive maneuvers aren't going to save us from that seeker.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAllButWeDoHaveASeekerToDealWith_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
                oncePerCombatTags = [ "NoOverlapBetweenShipsSeeker"],
                doesNotHaveArtifacts = ["ChaffEmitters"],
                anyDronesHostile = [ "missile_seeker" ],
                nonePresent = [ "crab" ],
                dialogue = [
                    new(AmVic, "observe", "Seekers don't care for firing lines. I would know.")
                ]
            }},
             {"BlockedAnEnemyAttackWithArmor_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyShotJustHit = true,
                minDamageBlockedByPlayerArmorThisTurn = 1,
                oncePerCombatTags = ["WowArmorISPrettyCoolHuh"],
                oncePerCombat = true,
                dialogue = [
                    new(AmVic, "happyneutral", "Excellent use of armor.")
                ]
            }},
             {"BlockedAnEnemyAttackWithArmor_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyShotJustHit = true,
                minDamageBlockedByPlayerArmorThisTurn = 1,
                oncePerCombatTags = ["WowArmorISPrettyCoolHuh"],
                oncePerCombat = true,
                dialogue = [
                    new(AmVic, "neutraltalk", "Armored part mitigated some damage.")
                ]
            }},
             {"ArtifactShieldPrepIsGone_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "ShieldPrepIsGoneYouFool" ],
                allPresent = [ AmVic ],
                doesNotHaveArtifacts = [ "ShieldPrep", "WarpMastery"],
                dialogue = [
                    new(AmVic, "observe", "We'll need to be even more prepared without Warp Prep.")
                ]
            }},
             {"AquiredHunterWings_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "HunterWings" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "HunterWings" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "These wing upgrades remind me of my old ship.")
                ]
            }},
             {"AquiredGlassCannon_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "GlassCannon" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "GlassCannon" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Can't say I like the weaker cannons, energy efficient as they are.")
                ]
            }},
             {"AquiredSimplicity_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "SimplicityShouts" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "Simplicity" ],
                dialogue = [
                    new(AmVic, "happyneutral", "Glad we decided to keep it simple.")
                ]
            }},
             {"AquiredDirtyEngines_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "DirtyEngines" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "DirtyEngines" ],
                dialogue = [
                    new(AmVic, "annoyed", "Really? These engines were banned for a reason.")
                ]
            }},
             {"AquiredIntercom_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "HiFreqIntercom" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "HiFreqIntercom" ],
                dialogue = [
                    new(AmVic, "annoyed", "This intercom is too bloody loud!")
                ]
            }},
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
             {"AquiredOverclockedMissileBay_Vic", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicOverclockedMissileBay" ],
                allPresent = [ AmVic ],
                hasArtifactTypes = [typeof(VicOverclockedMissileBay)],
                dialogue = [
                    new(AmVic, "pressured", "Be careful in the missile bay. This new model is...unstable.")
                ]
            }},
             {"AquiredVicLevelheaded_Vic_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicLevelheaded" ],
                allPresent = [ AmVic ],
                hasArtifactTypes = [typeof(VicLevelheaded)], 
                dialogue = [
                    new(AmVic, "neutraltalk", "I don't believe in ghosts.")
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
             {"AquiredNanofibers_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "NanofiberHullVic" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "NanofiberHull" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Nanofibers are excellent, but don't use them as a crutch.")
                ]
            }},
             {"AquiredCrosslink_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "CrosslinkVic" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "Crosslink" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Personally, I prefer the sidelink variation.")
                ]
            }},
             {"AquiredRecalibrator_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "RecalibratorVic" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "Recalibrator" ],
                dialogue = [
                    new(AmVic, "happyneutral", "Ah, recalibrator...")
                ]
            }},
             {"ArtifactEnergyPrep_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic ],
                hasArtifacts = [ "EnergyPrep" ],
                turnStart = true,
                maxTurnsThisCombat = 1,
                dialogue = [
                    new(AmVic, "pda", "Batteries are active. Use them wisely.")
                ]
            }},
             {"OverclockedGeneratorTic_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "OverclockedGeneratorTrigger" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pda", "Overclock cycle just ran over. Watch your energy.")
                ]
            }},
             {"EnergyRefundActivated_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                hasArtifacts = [ "EnergyRefund" ],
                minCostOfCardJustPlayed = 3,
                oncePerCombatTags = [ "EnergyRefund"],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pda", "Refund just recycled some power.")
                ]
            }},
             {"ArtifactFractureDetection_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic ],
                hasArtifacts = [ "FractureDetection" ],
                oncePerRunTags = [ "FractureDetectionBarks" ],
                turnStart = true,
                maxTurnsThisCombat = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "A seeker or two should find that brittle point.")
                ]
            }},
             {"ArtifactIonConverter_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic ],
                hasArtifacts = [ "IonConverter" ],
                oncePerRunTags = [ "IonConverterTag" ],
                lookup = [ "IonConverterTrigger" ],
                priority = true,
                dialogue = [
                    new(AmVic, "pressuredneutral", "...I forgot we had an ion converter.")
                ]
            }},
             {"ArtifactPaddle_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic ],
                hasArtifacts = [ "RicochetPaddle" ],
                oncePerRunTags = [ "RicochetPaddle" ],
                turnStart = true,
                maxTurnsThisCombat = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Be careful not to deflect my own missiles.")
                ]
            }},
             {"VicSmallMineLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                anyDrones = ["VicSmallSpaceMineTag"],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Let's see if they'll fall for this...")
                ]
            }},
             {"VicSmallMineLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                anyDrones = ["VicSmallSpaceMineTag"],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "happyneutral", "We can try a few mines. As a treat.")
                ]
            }},
             {"VicSmallMineLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                anyDrones = ["VicSmallSpaceMineTag"],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Not the most damaging, but the most disposable")
                ]
            }},
             {"VicSmallMineLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                anyDrones = ["VicSmallSpaceMineTag"],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "explains", "Toss enough mines and eventually they'll have an accident.")
                ]
            }},
             {"VicSmallMineLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                anyDrones = ["VicSmallSpaceMineTag"],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Watch your firing lines. I'm mucking up the midrow.")
                ]
            }},
             {"VicSmallMineLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                anyDrones = ["VicSmallSpaceMineTag"],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Small ordinance deployed.")
                ]
            }},
             {"VicMobileMineLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
                anyDrones = ["spaceMine"],
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "The worst trap is the one you’re forced to step in.")
                ]
            }},
             {"VicMobileMineLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
                anyDrones = ["spaceMine"],
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Never get shot when a mine can do that for you.")
                ]
            }},
             {"VicMobileMineLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
                anyDrones = ["spaceMine"],
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "explains", "The best way to obstruct a firing line.")
                ]
            }},
             {"VicMobileMineLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
                anyDrones = ["spaceMine"],
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Let’s make this inconvenient for them.")
                ]
            }},
             {"VicMobileMineLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
                anyDrones = ["spaceMine"],
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Try not to shoot this.")
                ]
            }},
             {"VicMobileMineLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
                anyDrones = ["spaceMine"],
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "I'm arranging for a convenient accident.")
                ]
            }},
             {"VicTorpedoLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                anyDrones = ["VicTorpedoTag"],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Always go for the engines.")
                ]
            }},
             {"VicTorpedoLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                anyDrones = ["VicTorpedoTag"],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "They aren't going anywhere.")
                ]
            }},
             {"VicTorpedoLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                anyDrones = ["VicTorpedoTag"],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Time to clip their wings.")
                ]
            }},
             {"VicTorpedoLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                anyDrones = ["VicTorpedoTag"],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Thruster deterrent in play.")
                ]
            }},
             {"VicTorpedoLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                anyDrones = ["VicTorpedoTag"],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Let's slow down a little.")
                ]
            }},
             {"VicTorpedoLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                anyDrones = ["VicTorpedoTag"],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "annoyed", "I've had enough of you flittering about.")
                ]
            }},
             {"VicCorrode_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lastTurnEnemyStatuses = [Status.corrode],
                oncePerRunTags = [ "VicCorrode" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pda", "Now we run the clock.")
                ]
            }},
             {"VicCorrode_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lastTurnEnemyStatuses = [Status.corrode],
                oncePerRunTags = [ "VicCorrode" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "observe", "Corrode's a bit of a warcrime, but...")
                ]
            }},
             {"VicCorrode_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lastTurnEnemyStatuses = [Status.corrode],
                oncePerRunTags = [ "VicCorrode" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "observe", "Suddenly, we have all the time in the world.")
                ]
            }},
             {"ShopkeeperInfinite_Vic_Multi_0", new(){
                type = NodeType.@event,
                lookup = [ "shopBefore" ],
                bg = "BGShop",
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmShopkeeper, "Need some upgrades?", true),
                    new(AmVic, "neutraltalk", "We're willing to pay top dollar."),
                    new(new Jump{key = "NewShop"})
                ]
            }},
             {"ShopkeeperInfinite_Vic_Multi_1", new(){
                type = NodeType.@event,
                lookup = [ "shopBefore" ],
                bg = "BGShop",
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmShopkeeper, "Still not satisfied with your ship?", true),
                    new(AmVic, "neutraltalk", "I have high standards."),
                    new(new Jump{key = "NewShop"})
                ]
            }},
             {"ShopkeeperInfinite_Vic_Multi_2", new(){
                type = NodeType.@event,
                lookup = [ "shopBefore" ],
                bg = "BGShop",
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmShopkeeper, "Here for business?", true),
                    new(AmVic, "neutraltalk", "I wouldn't be here otherwise."),
                    new(new Jump{key = "NewShop"})
                ]
            }},
             {"ArtifactTiderunner_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                allPresent = [ AmVic ],
                hasArtifacts = [ "TideRunner" ],
                oncePerRunTags = [ "TideRunner" ],
                dialogue = [
                    new(AmVic, "annoyed", "A ship made of wood? What bloody nonsense is this?")
                ]
            }},
             {"ArtifactAresCannon_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic ],
                hasArtifacts = [ "AresCannon" ],
                oncePerRunTags = [ "AresCannon" ],
                dialogue = [
                    new(AmVic, "happyneutral", "Small, armored, sleek black...it’s a perfect ship, really.")
                ]
            }},
             {"ArtifactGeminiCore_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                hasArtifacts = [ "GeminiCore" ],
                oncePerRunTags = [ "GeminiCore" ],
                dialogue = [
                    new(AmVic, "observe", "Quirky design, but I appreciate having two missile bays.")
                ]
            }},
             {"ArtifactJupiterMoons_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                hasArtifacts = [ "JupiterDroneHub" ],
                oncePerRunTags = [ "JupiterDroneHub" ],
                dialogue = [
                    new(AmVic, "observe", "A ship without cannons? Not ideal, but I can work with it.")
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}