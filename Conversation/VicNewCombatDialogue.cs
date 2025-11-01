using FMOD;
using Microsoft.Xna.Framework.Graphics;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using VicCharacter.Artifacts;
using VicCharacter.External;
using static VicCharacter.Conversation.CommonDefinitions;

namespace VicCharacter.Conversation;

internal class NewCombatDialogue : IRegisterable
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
                  new(AmVic, "neutraltalk", "All these loops...all these memories...")
                ]
            }},
            {"VicRemember_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "...How long have we been here? How long have we been alive?")
                ]
            }},
            {"VicRemember_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Will life be the same when we escape? If we escape?")
                ]
            }},
            {"VicRemember_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Does any of it matter? Will any of this be remembered?")
                ]
            }},
            {"VicRemember_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "The betrayal...the explosion...I remember...")
                ]
            }},
            {"VicRemember_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "...Is this truly endless? Will we truly be here forever?")
                ]
            }},
            {"VicRemember_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Who are we anymore? Are we still the same as before the loop?")
                ]
            }},
            {"VicRemember_7", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "...I almost don't want to remember. To be blissfully ignorant...")
                ]
            }},
            {"VicSeekerSwarmLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "I never miss.")
                ]
            }},
            {"VicSeekerSwarmLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Seekers have a lock.")
                ]
            }},
            {"VicSeekerSwarmLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Just try and dodge this.")
                ]
            }},
            {"VicSeekerSwarmLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "A little salvo should sort this out.")
                ]
            }},
            {"VicSeekerSwarmLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "You miss 100% of the missiles you don't launch.")
                ]
            }},
            {"VicEngineBoosterLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicEngineBooster" ],
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
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Older tech, but it stands the test of time")
                ]
            }},
            {"VicSatelliteLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Patching into our satellite array now.")
                ]
            }},
            {"VicSatelliteLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Invaluable combat logistics.")
                ]
            }},
            {"VicSatelliteLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Launching a sensor array.")
                ]
            }},
            {"VicSatelliteLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Even if it just blocks a shot, that's fine.")
                ]
            }},
            {"VicSatelliteLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Scanning system ready.")
                ]
            }},
            {"VicSatelliteLaunch_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSatellite" ],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Watch the computer. We're about to get new data.")
                ]
            }},
            {"VicBarrierLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "This is where they'll stop.")
                ]
            }},
            {"VicBarrierLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "They'll never get through this.")
                ]
            }},
            {"VicBarrierLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "High reflect barrier in play!")
                ]
            }},
            {"VicBarrierLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "I know that was expensive, but it'll be well worth it.")
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
                    new(AmVic, "neutraltalk", "Try a seeker missile next time.")
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
                    new(AmVic, "neutraltalk", "Try again.")
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
                    new(AmVic, "neutraltalk", "That could cost us.")
                ]
            }},
            {"WeMissedOopsie_Vic_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "neutraltalk", "No recalibrator? Pity.")
                ]
            }},
            {"WeMissedOopsie_Vic_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                doesNotHaveArtifacts = ["Recalibrator", "GrazerBeam"],
                dialogue = [
                    new(AmVic, "neutraltalk", "Unfortunate")
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
                    new(AmVic, "neutraltalk", "Excellent use of temporary shielding.")
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
                    new(AmVic, "neutraltalk", "Hull untouched. But don't get complacent.")
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
                    new(AmVic, "neutraltalk", "Line of fire: avoided.")
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
                    new(AmVic, "neutraltalk", "Excellent evasive maneuvers.")
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
                oncePerCombatTags = [ "NoOverlapBetweenShipsSeeker"],
                anyDronesHostile = [ "missile_seeker" ],
                nonePresent = [ "crab" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "...Seems they're using my own tactics against us.")
                ]
            }},
             {"WeDontOverlapWithEnemyAtAllButWeDoHaveASeekerToDealWith_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                shipsDontOverlapAtAll = true,
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
                anyDronesHostile = [ "missile_seeker" ],
                nonePresent = [ "crab" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Seekers don't care for firing lines. I would know.")
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
                    new(AmVic, "neutraltalk", "Good use of armor.")
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
                    new(AmVic, "neutraltalk", "We'll need to be even more prepared without Warp Prep.")
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
                    new(AmVic, "neutraltalk", "Glad we decided to keep it simple.")
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
                    new(AmVic, "neutraltalk", "Are you sure this shield generator is stable?"),
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
                    new(AmVic, "neutraltalk", "Give 'em hell, Hyperia."),
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
                    new(AmVic, "neutraltalk", "Not sure if I'd take the heat over dirtier engines."),
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
                    new(AmVic, "neutraltalk", "The cockpit is...different."),
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
                    new(AmVic, "neutraltalk", "Your adaptability is astounding, Cat."),
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
                    new(AmVic, "neutraltalk", "Be careful in the missile bay. This new model is...unstable.")
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
                    new(AmVic, "neutraltalk", "What?! Of course not!")
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
                    new(AmVic, "neutraltalk", "I have no idea what you're talking about.")
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
                    new(AmVic, "neutraltalk", "Ghosts? Don't be ridiculous.")
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
                    new(AmVic, "neutraltalk", "Ah, recalibrator...")
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
                    new(AmVic, "neutraltalk", "Batteries are active. Use them wisely.")
                ]
            }},
             {"AquiredEnergyPrep_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmVic ],
                hasArtifacts = [ "EnergyPrep" ],
                turnStart = true,
                maxTurnsThisCombat = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Batteries are active. Use them wisely.")
                ]
            }},
             {"OverclockedGeneratorTic_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "OverclockedGeneratorTrigger" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Overclock cycle just ran over. Watch your energy.")
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
                  new(AmVic, "neutraltalk", "Refund just recycled some power.")
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
                    new(AmVic, "...I forgot we had an ion converter.")
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
                    new(AmVic, "neutraltalk", "Be careful not to deflect my own missiles with a ricochet.")
                ]
            }},
             {"VicSmallMineLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
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
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "We can try a few mines. As a treat.")
                ]
            }},
             {"VicSmallMineLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
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
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Toss enough mines and eventually they'll have an accident.")
                ]
            }},
             {"VicSmallMineLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Watch your firing lines - I'm mucking up the midrow.")
                ]
            }},
             {"VicSmallMineLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSmallMinefield" ],
                oncePerCombatTags = [ "VicSmallMinefield" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Small ordinance deployed!")
                ]
            }},
             {"VicMobileMineLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
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
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "The best way to obstruct a firing line.")
                ]
            }},
             {"VicMobileMineLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicMobileMine" ],
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
                oncePerCombatTags = [ "VicMobileMine" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "I'm arranging for a convenient accident.")
                ]
            }},
             {"VicTorpedoLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
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
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Thruster deterrent launched.")
                ]
            }},
             {"VicTorpedoLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "It'd be real nice if you stopped moving just about now.")
                ]
            }},
             {"VicTorpedoLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Let's slow down a little.")
                ]
            }},
             {"VicTorpedoLaunch_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicTorpedoLaunch" ],
                oncePerCombatTags = [ "VicTorpedoLaunch" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "I've had enough of you flittering about.")
                ]
            }},
             {"VicCorrode_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lastTurnEnemyStatuses = [Status.corrode],
                oncePerRunTags = [ "VicCorrode" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Now we run the clock.")
                ]
            }},
             {"VicCorrode_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lastTurnEnemyStatuses = [Status.corrode],
                oncePerRunTags = [ "VicCorrode" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Corrode's a bit of a warcrime, but...")
                ]
            }},
             {"VicCorrode_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lastTurnEnemyStatuses = [Status.corrode],
                oncePerRunTags = [ "VicCorrode" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Suddenly, we have all the time in the world.")
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
                    new(AmVic, "neutraltalk", "Small, armored, sleek black...it’s a perfect ship, really.")
                ]
            }},
             {"ArtifactGeminiCore_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                hasArtifacts = [ "GeminiCore" ],
                oncePerRunTags = [ "GeminiCore" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Quirky design, but I appreciate having two missile bays.")
                ]
            }},
             {"ArtifactJupiterMoons_Vic", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                hasArtifacts = [ "JupiterDroneHub" ],
                oncePerRunTags = [ "JupiterDroneHub" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "A ship without cannons? Not ideal, but I can work with it.")
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}