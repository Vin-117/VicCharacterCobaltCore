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
                  new(AmVic, "pensive", "All these loops...all these memories...")
                ]
            }},
            {"VicRemember_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "...How long have we been here? How long have we been alive?")
                ]
            }},
            {"VicRemember_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "Will life be the same when we escape? If we escape?")
                ]
            }},
            {"VicRemember_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "Does any of it matter? Will any of this be remembered?")
                ]
            }},
            {"VicRemember_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "I remember it so clearly. And yet, it blurs together...")
                ]
            }},
            {"VicRemember_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "Will we be here forever? Will we even know?")
                ]
            }},
            {"VicRemember_6", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "Who are we anymore? Are we still the same as before the loop?")
                ]
            }},
            {"VicRemember_7", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicRemember" ],
                oncePerRunTags = [ "VicRemember" ],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "pensive", "...I almost don't want to remember. To be blissfully ignorant...")
                ]
            }},
            {"VicHeavySeekerSwarmLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "Heavy seekers locked.")
                ]
            }},
            {"VicHeavySeekerSwarmLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Get ready for the fireworks.")
                ]
            }},
            {"VicHeavySeekerSwarmLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "If you thought regular seekers were bad enough...")
                ]
            }},
            {"VicHeavySeekerSwarmLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "You'll wish these could miss.")
                ]
            }},
            {"VicHeavySeekerSwarmLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = [ "VicSeekerOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "Heavy seekers in play.")
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
                  new(AmVic, "pda", "Missile payload ready.")
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
                  new(AmVic, "pda", "Let's see how they deal with this.")
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
                  new(AmVic, "pda", "I have a lock.")
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


            {"VicHeavySeekerSwarmAntiAutoDodgeLeft_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeLeft],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Autododge? I don't think so.")
                ]
            }},
            {"VicHeavySeekerSwarmAntiAutoDodgeLeft_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeLeft],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "I told you. I don't miss.")
                ]
            }},
            {"VicHeavySeekerSwarmAntiAutoDodgeLeft_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeLeft],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Nice try with those evasive maneuvers.")
                ]
            }},
            {"VicHeavySeekerSwarmAntiAutoDodgeRight_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeRight],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Autododge? I don't think so.")
                ]
            }},
            {"VicHeavySeekerSwarmAntiAutoDodgeRight_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeRight],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "I told you. I don't miss.")
                ]
            }},
            {"VicHeavySeekerSwarmAntiAutoDodgeRight_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicHeavySeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeRight],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Nice try with those evasive maneuvers.")
                ]
            }},
            {"VicSeekerSwarmAntiAutoDodgeLeft_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeLeft],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Autododge? I don't think so.")
                ]
            }},
            {"VicSeekerSwarmAntiAutoDodgeLeft_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeLeft],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                anyDrones = [ "missile_seeker" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "I told you. I don't miss.")
                ]
            }},
            {"VicSeekerSwarmAntiAutoDodgeLeft_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                lastTurnEnemyStatuses = [Status.autododgeLeft],
                anyDrones = [ "missile_seeker" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Nice try with those evasive maneuvers.")
                ]
            }},
            {"VicSeekerSwarmAntiAutoDodgeRight_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeRight],
                anyDrones = [ "VicHeavySeekerTag" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Autododge? I don't think so.")
                ]
            }},
            {"VicSeekerSwarmAntiAutoDodgeRight_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                lastTurnEnemyStatuses = [Status.autododgeRight],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                anyDrones = [ "missile_seeker" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pdasmile", "I told you. I don't miss.")
                ]
            }},
            {"VicSeekerSwarmAntiAutoDodgeRight_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicSeekerSwarm" ],
                oncePerCombatTags = ["VicLaughsAtAutoDodge"],
                lastTurnEnemyStatuses = [Status.autododgeRight],
                anyDrones = [ "missile_seeker" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "smug", "Nice try with those evasive maneuvers.")
                ]
            }},
            {"VicShifterDroneLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Positional disrupter online.")
                ]
            }},
            {"VicShifterDroneLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Time to shake things up.")
                ]
            }},
            {"VicShifterDroneLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "neutraltalk", "Let's move our problems somewhere else.")
                ]
            }},
            {"VicShifterDroneLaunch_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "observe", "Watch their position. It's about to get complicated.")
                ]
            }},
            {"VicShifterDroneLaunch_4", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Shift drone is ready.")
                ]
            }},
            {"VicShifterDroneLaunch_5", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "Better hope you don't get motion sickness.")
                ]
            }},
            {"VicIsaacShifterDroneLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerRunTags = ["IsaacYapAboutShiftDrone"],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "sly", "I'm feeling a little shifty..."),
                  new(AmVic, "annoyed", "Not funny.")
                ]
            }},
            {"VicIsaacShifterDroneLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerRunTags = ["IsaacYapAboutShiftDrone"],
                oncePerCombat = true,
                dialogue = [
                    new(AmIsaac, "sly", "Did you always have a habit of pushing people away?"),
                    new(AmVic, "doubtful", "When did you become a comedian?")
                ]
            }},
            {"VicIsaacShifterDroneLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicShifterDrone" ],
                anyDronesFriendly = ["VicShifterDroneTag"],
                oncePerCombatTags = [ "VicShifterDroneOnce" ],
                oncePerRunTags = ["IsaacYapAboutShiftDrone"],
                oncePerCombat = true,
                dialogue = [
                    new(AmIsaac, "shy", "It's hard to track where their ship is going to go."),
                    new(AmVic, "observe", "Absolutely. We'll need to be careful with this.")
                ]
            }},
            {"VicIsaacEngineBoosterLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerRunTags = ["IsaacYapAboutEngineBooster"],
                oncePerCombat = true,
                dialogue = [
                    new(AmIsaac, "shy", "Aren't some of those parts a little expensive?"),
                    new(AmVic, "observe", "They were never designed to be mass produced.")
                ]
            }},
            {"VicIsaacEngineBoosterLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerRunTags = ["IsaacYapAboutEngineBooster"],
                oncePerCombat = true,
                dialogue = [
                    new(AmIsaac, "Kind of like a shield drone, huh?"),
                    new(AmVic, "neutraltalk", "Yes. It cycles power into the engines instead of shields.")
                ]
            }},
            {"VicIsaacEngineBoosterLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicEngineBooster" ],
                anyDronesFriendly = ["VicEngineBoosterTag"],
                oncePerCombatTags = [ "VicEngineBoosterOnce" ],
                oncePerRunTags = ["IsaacYapAboutEngineBooster"],
                oncePerCombat = true,
                dialogue = [
                    new(AmVic, "neutraltalk", "If I'm going to name this one, I'll go with Wing."),
                    new(AmIsaac, "shy", "Try again.")
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
                  new(AmVic, "pda", "This'll put a kick in our thrusters.")
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
                  new(AmVic, "pda", "Engine booster in play.")
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
                  new(AmVic, "neutraltalk", "Try to keep this alive. You'll thank me later.")
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
                  new(AmVic, "neutraltalk", "A little backdraft wouldn't hurt.")
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
                  new(AmVic, "neutraltalk", "Mind that drone. They aren't disposable.")
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
                  new(AmVic, "pda", "Time to spread our wings.")
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
                  new(AmVic, "pda", "Launching a sensor node.")
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
            {"VicIsaacSatelliteLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRunTags = ["IsaacYapAboutSatellite"],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "Why don't you name your drones?"),
                  new(AmVic, "neutraltalk", "They never live that long."),
                ]
            }},
            {"VicIsaacSatelliteLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRunTags = ["IsaacYapAboutSatellite"],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "Did you design that satellite yourself?"),
                  new(AmVic, "observe", "Built? Yes. Designed? No."),
                ]
            }},
            {"VicIsaacSatelliteLaunch_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicSatellite" ],
                anyDronesFriendly = ["SignalAmplifierTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRunTags = ["IsaacYapAboutSatellite"],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "shy", "These sensor nodes seem a little archaic..."),
                  new(AmVic, "pda", "It's an older design, but it checks out."),
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
            {"VicIsaacSatelliteUpgradedLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerRunTags = ["IsaacYapAboutSatelliteUpgrade"],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "Wow! That's a big improvement!"),
                  new(AmVic, "explains", "Saw you working on your drones and had to stay ahead.")
                ]
            }},
            {"VicIsaacSatelliteUpgradedLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicSatelliteUpgraded" ],
                anyDronesFriendly = ["SignalAmplifierUpgradedTag"],
                oncePerRunTags = ["IsaacYapAboutSatelliteUpgrade"],
                oncePerCombatTags = [ "VicSatelliteOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmIsaac, "shy", "I might need to make MKIII drone at this rate."),
                  new(AmVic, "happy", "I'd welcome the competition.")
                ]
            }},
            {"VicBarrierLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "pda", "This'll last a long time.")
                ]
            }},
            {"VicBarrierLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                  new(AmVic, "observe", "Don't shoot this. Trust me.")
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
                  new(AmVic, "pda", "Kinetic barrier stabilized.")
                ]
            }},
            {"VicIsaacBarrierLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                oncePerRunTags = ["CrewYapAboutBarrier"],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerCombat = true,
                dialogue = [
                    new(AmIsaac, "shy", "What is that thing?"),
                    new(AmVic, "pda", "Indestructible.")
                ]
            }},
            {"VicIsaacBarrierLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerRunTags = ["CrewYapAboutBarrier"],
                oncePerCombat = true,
                dialogue = [
                    new(AmIsaac, "shy", "...That took a lot of energy."),
                    new(AmVic, "pda", "Well worth it, I assure you.")
                ]
            }},
            {"VicDizzyBarrierLaunch_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDizzy ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerRunTags = ["CrewYapAboutBarrier"],
                oncePerCombat = true,
                dialogue = [
                    new(AmVic, "pda", "With just the right balance, you create a nigh indestructible EM field."),
                    new(AmDizzy, "Fascinating!")
                ]
            }},
            {"VicDizzyBarrierLaunch_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDizzy ],
                lookup = [ "VicKineticBarrierUp" ],
                oncePerCombatTags = [ "VicBarrierOnce" ],
                oncePerRunTags = ["CrewYapAboutBarrier"],
                oncePerCombat = true,
                dialogue = [
                    new(AmDizzy, "Is that thing actually invincible?"),
                    new(AmVic, "observe", "It'll linger until the heat death of the universe."),
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
                    new(AmVic, "happyneutral", "Hull untouched.")
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
                    new(AmVic, "happyneutral", "Line of fire: avoided.")
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
                    new(AmVic, "annoyed", "This intercom is too bloody loud.")
                ]
            }},
             {"AquiredOverclockedMissileBay_Vic", new(){
                type = NodeType.combat,
                priority = false,
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
            {"AquiredOverclockedMissileBay_VicIsaac", new(){
                type = NodeType.combat,
                priority = false,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicOverclockedMissileBay" ],
                allPresent = [ AmVic, AmIsaac ],
                hasArtifactTypes = [typeof(VicOverclockedMissileBay)],
                dialogue = [
                    new(AmIsaac, "shy", "A model S-Z bay? This thing is banned in five sectors."),
                    new(AmVic, "observe", "That is true. But no other model beats it for energy efficiency.")
                ]
            }},
            {"AquiredOverclockedMissileBay_VicPeri", new(){
                type = NodeType.combat,
                priority = false,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicOverclockedMissileBay" ],
                allPresent = [ AmVic, AmPeri ],
                hasArtifactTypes = [typeof(VicOverclockedMissileBay)],
                dialogue = [
                    new(AmPeri, "Is the missile bay supposed to make those sounds?"),
                    new(AmVic, "observe", "Don't worry about it.")
                ]
            }},
             {"AquiredPowerReserve_Vic", new(){
                type = NodeType.combat,
                priority = true,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicPowerReserve" ],
                allPresent = [ AmVic ],
                hasArtifactTypes = [typeof(VicPowerReserve)],
                dialogue = [
                    new(AmVic, "happy", "A proper energy system. Finally.")
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

             {"CATsummonedGarrusCard_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmCat ],
                nonePresent = [ AmVic ],
                lookup = [ "summonGarrus" ],
                dialogue = [
                    new(AmCat, "squint", "What would Garrus do here?")
                ]
            }},

             {"CATsummonedGarrusAndGarrusIsHereCard_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                allPresent = [ AmCat, AmVic ],
                lookup = [ "summonGarrus" ],
                dialogue = [
                    new(AmVic, "happyneutral", "Your adaptability is astounding, Cat."),
                    new(AmCat, "smug", "That's why I'm here!"),
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

             {"NanofibersCantHelpThat_Vic_0", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                minDamageDealtToPlayerThisTurn = 2,
                hasArtifacts = [ "NanofiberHull" ],
                doesNotHaveArtifacts = [ "HealBooster" ],
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "doubtful", "What did I say about relying too much on nanofibers?")
                ]
            }},
             {"BoostedNanofibersCantHelpThat_Vic_0", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                minDamageDealtToPlayerThisTurn = 3,
                hasArtifacts = [ "NanofiberHull", "HealBooster" ],
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "doubtful", "Got overconfident with boosted nanofibers, didn't you?")
                ]
            }},
             {"AquiredNanofibersAndHealbooster_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "NanofiberHullVic" ],
                allPresent = [ AmVic ],
                hasArtifacts = [ "NanofiberHull", "HealBooster" ],
                dialogue = [
                    new(AmVic, "observe", "Don't get overconfident. Even boosted nanofibers aren't enough at times.")
                ]
            }},
             {"AquiredCrosslink_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "CrosslinkVic" ],
                allPresent = [ AmVic ],
                nonePresent = [ AmPeri ],
                hasArtifacts = [ "Crosslink" ],
                dialogue = [
                    new(AmVic, "observe", "Personally, I prefer the sidelink variation.")
                ]
            }},
             {"AquiredCrosslinkBut_VicAndPeriFightAboutit", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "CrosslinkVic" ],
                allPresent = [ AmVic, AmPeri ],
                hasArtifacts = [ "Crosslink" ],
                dialogue = [
                    new(AmVic, "neutraltalk", "The sidelink variant was better."),
                    new(AmPeri, "squint", "I'll have to respectfully disagree with that, sir.")
                ]
            }},

             {"AquiredLightSpeedBootDisk_Vic", new(){
                type = NodeType.combat,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                allPresent = [ AmVic, AmMax ],
                hasArtifacts = [ "LightspeedBootDisk" ],
                dialogue = [
                    new(AmVic, "pdasmile", "Ah, an LSB model? Good taste."),
                    new(AmMax, "smile", "All the best PCs have it!")
                ]
            }},

             {"AquiredSidelink_Vic", new(){
                type = NodeType.combat,
                priority = false,
                oncePerRun = true,
                turnStart = true,
                maxTurnsThisCombat = 1,
                oncePerRunTags = [ "VicLovesSidelink" ],
                allPresent = [ AmVic ],
                hasArtifactTypes = [typeof(VicSidelink)],
                dialogue = [
                    new(AmVic, "happyneutral", "Ah, sidelink...")
                ]
            }},
             {"VicSidelinkKickedIn_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                lookup = [ "SidelinkTrigger" ],
                oncePerCombatTags = ["YappingAboutSidelink"],
                oncePerRun = true,
                dialogue = [
                  new(AmVic, "explains", "Every ship should come with sidelink.")
                ]
            }},
             {"VicSidelinkKickedInWithIsaac_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                lookup = [ "SidelinkTrigger" ],
                oncePerCombatTags = ["YappingAboutSidelink"],
                oncePerRun = true,
                dialogue = [
                  new(AmIsaac, "I had no idea there was a crosslink variation for drones!"),
                  new(AmVic, "happyneutral", "Convenient, isn't it?")
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
             {"WeAreRecalibrating_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                hasArtifacts = [ "Recalibrator"],
                dialogue = [
                    new(AmVic, "pdasmile", "Recalibrator is working seamlessly.")
                ]
            }},
             {"WeAreRecalibrating_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                hasArtifacts = [ "Recalibrator"],
                dialogue = [
                    new(AmVic, "explains", "Nothing but a calculated miss.")
                ]
            }},

             {"WeAreRecalibrating_VicPeri_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmPeri ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                oncePerRun = true,
                hasArtifacts = [ "Recalibrator"],
                dialogue = [
                    new(AmVic, "happyneutral", "Hyperia? Miss again."),
                    new(AmPeri, "vengeful", "Sir yes sir.")
                ]
            }},

             {"WeAreRecalibrating_VicDrake_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDrake ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                oncePerRun = true,
                hasArtifacts = [ "Recalibrator"],
                dialogue = [
                    new(AmDrake, "squint", "Really? Missing on purpose?"),
                    new(AmVic, "explains", "Recalibrating is its own joy.")
                ]
            }},

             {"WeAreRecalibratingANDGrazing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                hasArtifacts = [ "Recalibrator", "GrazerBeam" ],
                dialogue = [
                    new(AmVic, "happyneutral", "Recalibrating grazer beam? Excellent!")
                ]
            }},
             {"WeAreRecalibratingANDGrazing_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustMissed = true,
                oncePerCombatTags = [ "VicMissedShotOnce" ],
                oncePerCombat = true,
                hasArtifacts = [ "Recalibrator", "GrazerBeam" ],
                dialogue = [
                    new(AmVic, "happyneutral", "At this point, why not miss on purpose?")
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
                  new(AmVic, "neutraltalk", "Let's keep them busy.")
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
                  new(AmVic, "neutraltalk", "Toss enough mines and eventually they'll have an accident.")
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
                  new(AmVic, "neutraltalk", "The worst trap is the one you're forced to step in.")
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
                  new(AmVic, "neutraltalk", "The best way to obstruct a firing line.")
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
                  new(AmVic, "pda", "Let's make this inconvenient for them.")
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
                  new(AmVic, "neutraltalk", "I'm arranging for a convenient accident.")
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
                    new(AmVic, "happyneutral", "Small, armored, sleek black...its a perfect ship, really.")
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
             {"OverheatGeneric_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                goingToOverheat = true,
                oncePerCombatTags = ["OverheatGeneric"],
                dialogue = [
                    new(AmVic, "panic", "Prepare for emergency venting!")
                ]
            }},
             {"WeJustGainedHeatAndDrakeIsHere_Multi_0", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "annoyed", "Really, Drake?"),
                ]
            }},
             {"TookChipDamage_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyShotJustHit = true,
                doesNotHaveArtifacts = [ "NanofiberHull" ],
                oncePerCombatTags = ["VicYappedAboutMinorDMG"],
                minDamageDealtToPlayerThisTurn = 1,
                maxDamageDealtToPlayerThisTurn = 2,
                dialogue = [
                    new(AmVic, "neutraltalk", "Minor damage sustained.")
                ]
            }},
             {"TookChipDamage_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyShotJustHit = true,
                doesNotHaveArtifacts = [ "NanofiberHull" ],
                oncePerCombatTags = ["VicYappedAboutMinorDMG"],
                minDamageDealtToPlayerThisTurn = 1,
                maxDamageDealtToPlayerThisTurn = 2,
                dialogue = [
                    new(AmVic, "observe", "Not ideal, but fixable.")
                ]
            }},
             {"TookChipDamage_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyShotJustHit = true,
                doesNotHaveArtifacts = [ "NanofiberHull" ],
                oncePerCombatTags = ["VicYappedAboutMinorDMG"],
                minDamageDealtToPlayerThisTurn = 1,
                maxDamageDealtToPlayerThisTurn = 2,
                dialogue = [
                    new(AmVic, "pda", "Let's try and avoid more damage if we can help it.")
                ]
            }},
             {"TookChipDamage_Vic_3", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyShotJustHit = true,
                doesNotHaveArtifacts = [ "NanofiberHull" ],
                oncePerCombatTags = ["VicYappedAboutMinorDMG"],
                minDamageDealtToPlayerThisTurn = 1,
                maxDamageDealtToPlayerThisTurn = 2,
                dialogue = [
                    new(AmVic, "neutraltalk", "I'll consider that an acceptable loss.")
                ]
            }},
             {"ThatsALotOfDamageToUs_Vic_0", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                minDamageDealtToPlayerThisTurn = 3,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Keep your cool. We aren't debris yet.")
                ]
            }},
             {"ThatsALotOfDamageToUs_Vic_1", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                minDamageDealtToPlayerThisTurn = 3,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "pdapressured", "This...isn't good.")
                ]
            }},
             {"ThatsALotOfDamageToUs_Vic_2", new(){
                type = NodeType.combat,
                enemyShotJustHit = true,
                minDamageDealtToPlayerThisTurn = 3,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "pressuredneutral", "Multiple hull breaches, but...we're alive.")
                ]
            }},
             {"JustHitGeneric_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustHit = true,
                minDamageDealtToEnemyThisAction = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Good impact.")
                ]
            }},
             {"JustHitGeneric_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustHit = true,
                minDamageDealtToEnemyThisAction = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Hit confirmed.")
                ]
            }},
             {"JustHitGeneric_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                playerShotJustHit = true,
                minDamageDealtToEnemyThisAction = 1,
                dialogue = [
                    new(AmVic, "neutraltalk", "Shot connected.")
                ]
            }},
             {"ThatsALotOfDamageToThem_Vic_0", new(){
                type = NodeType.combat,
                playerShotJustHit = true,
                minDamageDealtToEnemyThisTurn = 10,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "pda", "They won't last long after that.")
                ]
            }},
             {"ThatsALotOfDamageToThem_Vic_1", new(){
                type = NodeType.combat,
                playerShotJustHit = true,
                minDamageDealtToEnemyThisTurn = 10,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "smug", "No less than what they deserve.")
                ]
            }},
             {"ThatsALotOfDamageToThem_Vic_2", new(){
                type = NodeType.combat,
                playerShotJustHit = true,
                minDamageDealtToEnemyThisTurn = 10,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "smug", "I don't believe in warning shots.")
                ]
            }},
             {"WeAreMovingAroundALot_Vic_0", new(){
                type = NodeType.combat,
                minMovesThisTurn = 3,
                oncePerRun = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "observe", "...Faster manuevering than I expected.")
                ]
            }},
             {"WeAreMovingAroundALot_Vic_1", new(){
                type = NodeType.combat,
                minMovesThisTurn = 3,
                oncePerRun = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "neutraltalk", "Strap in. This ride isn't over yet.")
                ]
            }},
             {"WeAreMovingAroundALot_Vic_2", new(){
                type = NodeType.combat,
                minMovesThisTurn = 3,
                oncePerRun = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "pda", "We really make this ship dance, don't we?")
                ]
            }},
             {"HandOnlyHasTrashCards_Vic_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                handFullOfTrash = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "annoyed", "What the hell is this garbage?")
                ]
            }},
            {"HandOnlyHasUnplayableCards_Vic_0", new(){
                type = NodeType.combat,
                oncePerRun = true,
                handFullOfUnplayableCards = true,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "annoyed", "Can someone please clear the bridge?")
                ]
            }},
            {"BooksWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["booksWentMissing"],
                lastTurnPlayerStatuses = [Status.missingBooks],
                dialogue = [
                    new(AmVic, "observe", "Did that kid just sneak off?")
                ]
            }},
            {"CatWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["CatWentMissing"],
                lastTurnPlayerStatuses = [Status.missingCat],
                dialogue = [
                    new(AmVic, "pressured", "Where did CAT go?")
                ]
            }},
            {"DizzyWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["dizzyWentMissing"],
                lastTurnPlayerStatuses = [Status.missingDizzy],
                dialogue = [
                    new(AmVic, "observe", "Our science officer just vanished.")
                ]
            }},
            {"DrakeWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["drakeWentMissing"],
                lastTurnPlayerStatuses = [Status.missingDrake],
                dialogue = [
                    new(AmVic, "annoyed", "Of course she'd disappear on us now...")
                ]
            }},
            {"IsaacWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["issacWentMissing"],
                lastTurnPlayerStatuses = [Status.missingIsaac],

                dialogue = [
                    new(AmVic, "panic", "Isaac?!")
                ]
            }},
            {"MaxWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["maxWentMissing"],
                lastTurnPlayerStatuses = [Status.missingMax],
                dialogue = [
                    new(AmVic, "pdapressured", "...Why did Max suddenly log out?")
                ]
            }},
            {"PeriWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["periWentMissing"],
                lastTurnPlayerStatuses = [Status.missingPeri],
                dialogue = [
                    new(AmVic, "panic", "Hyperia?! Where the hell are you?")
                ]
            }},
            {"RiggsWentMissing_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["riggsWentMissing"],
                lastTurnPlayerStatuses = [Status.missingRiggs],
                dialogue = [
                    new(AmVic, "observe", "...Where did our pilot go?")
                ]
            }},
            {"VicWentMissing_Peri_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmPeri ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmPeri, "panic", "...Sir?!")
                ]
            }},
            {"VicWentMissing_Isaac_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmIsaac ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmIsaac, "panic", "Garrus?!")
                ]
            }},
            {"VicWentMissing_Riggs_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmRiggs ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmRiggs, "squint", "Are we missing someone? Or is that just me?")
                ]
            }},
            {"VicWentMissing_Dizzy_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDizzy ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmDizzy, "intense", "Hey guys? The commander is gone.")
                ]
            }},
            {"VicWentMissing_Drake_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmDrake ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmDrake, "sly", "Finally. Now he won't boss me around anymore.")
                ]
            }},
            {"VicWentMissing_Books_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmBooks ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmBooks, "paws", "Wow! Garrus is playing hide and seek!")
                ]
            }},
            {"VicWentMissing_Cat_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmCat ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmCat, "worried", "Garrus?")
                ]
            }},
            {"VicWentMissing_Max_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic, AmMax ],
                priority = true,
                oncePerRun = true,
                oncePerCombatTags = ["VicWentMissing"],
                lastTurnPlayerStatuses = [MissingVic],
                dialogue = [
                    new(AmMax, "intense", "Uh...Garrus?")
                ]
            }},
            {"EnemyHasBrittle_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyHasBrittlePart = true,
                oncePerRunTags = ["yelledAboutBrittle"],
                dialogue = [
                    new(AmVic, "pda", "Try for that brittle spot if you can.")
                ]
            }},
            {"EnemyHasBrittle_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyHasBrittlePart = true,
                oncePerRunTags = ["yelledAboutBrittle"],
                dialogue = [
                    new(AmVic, "pda", "Reading a significant vulnerable point on the enemy ship.")
                ]
            }},
            {"EnemyHasWeakness_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyHasWeakPart = true,
                oncePerRunTags = ["yelledAboutWeakness"],
                dialogue = [
                    new(AmVic, "neutraltalk", "I see a weak link.")
                ]
            }},
            {"EnemyHasWeakness_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                enemyHasWeakPart = true,
                oncePerRunTags = ["yelledAboutWeakness"],
                dialogue = [
                    new(AmVic, "neutraltalk", "Go for the weaker bit if you can.")
                ]
            }},
            {"ExpensiveCardPlayed_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minCostOfCardJustPlayed = 4,
                oncePerCombatTags = ["ExpensiveCardPlayed"],
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "pdapressured", "That was an expensive move.")
                ]
            }},
            {"ExpensiveCardPlayed_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minCostOfCardJustPlayed = 4,
                oncePerCombatTags = ["ExpensiveCardPlayed"],
                oncePerRun = true,
                dialogue = [
                    new(AmVic, "pdapressured", "I hope that was worth it.")
                ]
            }},
            {"ManyTurns_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minTurnsThisCombat = 9,
                oncePerCombatTags = ["manyTurns"],
                dialogue = [
                    new(AmVic, "neutraltalk", "This is a long skirmish.")
                ]
            }},
            {"ManyTurns_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minTurnsThisCombat = 9,
                oncePerCombatTags = ["manyTurns"],
                dialogue = [
                    new(AmVic, "neutraltalk", "Play it slow. Play it safe.")
                ]
            }},
            {"ManyTurns_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minTurnsThisCombat = 9,
                oncePerCombatTags = ["manyTurns"],
                dialogue = [
                    new(AmVic, "neutraltalk", "I've been in fights far longer than this.")
                ]
            }},
            {"VeryManyTurns_Vic_0", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minTurnsThisCombat = 20,
                oncePerCombatTags = ["veryManyTurns"],
                oncePerRun = true,
                turnStart = true,
                dialogue = [
                    new(AmVic, "pensive", "If this is how long it takes to win, so be it.")
                ]
            }},
            {"VeryManyTurns_Vic_1", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minTurnsThisCombat = 20,
                oncePerCombatTags = ["veryManyTurns"],
                oncePerRun = true,
                turnStart = true,
                dialogue = [
                    new(AmVic, "pda", "...Maybe this is taking too long.")
                ]
            }},
            {"VeryManyTurns_Vic_2", new(){
                type = NodeType.combat,
                allPresent = [ AmVic ],
                minTurnsThisCombat = 20,
                oncePerCombatTags = ["veryManyTurns"],
                oncePerRun = true,
                turnStart = true,
                dialogue = [
                    new(AmVic, "determined", "No matter how long, I won't give up.")
                ]
            }},
            {"PlayedManyCards_Vic_0", new(){
                type = NodeType.combat,
                oncePerCombatTags = ["vicManyCardsPlayed"],
                oncePerCombat = true,
                minCardsPlayedThisTurn = 12,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "happy", "Great work, team.")
                ]
            }},
            {"PlayedManyCards_Vic_1", new(){
                type = NodeType.combat,
                oncePerCombatTags = ["vicManyCardsPlayed"],
                oncePerCombat = true,
                minCardsPlayedThisTurn = 12,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "happyneutral", "Excellent efficiency!")
                ]
            }},
            {"PlayedManyCards_Vic_2", new(){
                type = NodeType.combat,
                oncePerCombatTags = ["vicManyCardsPlayed"],
                oncePerCombat = true,
                minCardsPlayedThisTurn = 12,
                allPresent = [ AmVic ],
                dialogue = [
                    new(AmVic, "happyneutral", "Amazing job!")
                ]
            }},
            {"BanditThreats_Multi_0", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "smug", "How about we give you a double portion?")
                ]
            }},
            {"CrabFacts1_Multi_0", new(){
                edit = [
                    new(EMod.countFromStart, 2, AmVic, "annoyed", "What the hell are you talking about?")
                ]
            }},
            {"CrabFacts2_Multi_0", new(){
                edit = [
                    new(EMod.countFromStart, 2, AmVic, "doubtful", "This is complete rubbish.")
                ]
            }},
            {"CrabFactsAreOverNow_Multi_0", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "annoyed", "I'd had enough of your nonsense.")
                ]
            }},
            {"DillianShouts", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "neutraltalk", "Good day.")
                ]
            }},
            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}
