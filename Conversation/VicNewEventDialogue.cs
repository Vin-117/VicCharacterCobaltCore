using FMOD;
using Microsoft.Xna.Framework.Graphics;
using Nanoray.PluginManager;
using Nickel;
using System.Collections.Generic;
using VicCharacter.Artifacts;
using VicCharacter.External;
using static VicCharacter.Conversation.CommonDefinitions;

namespace VicCharacter.Conversation;

internal class VicNewEventDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", new Dictionary<string, DialogueMachine>(){
            {$"ChoiceCardRewardOfYourColorChoice_{AmVic}", new(){
                type = NodeType.@event,
                oncePerRun = true,
                allPresent = [ AmVic ],
                bg = "BGBootSequence",
                dialogue = [
                    new(AmVic, "squint", "I have a pounding headache."),
                    new(AmCat, "Energy readings are back to normal.")
                ]
            }},
            {$"CrystallizedFriendEvent_{AmVic}", new(){
                type = NodeType.@event,
                oncePerRun = true,
                allPresent = [ AmVic ],
                bg = "BGCrystalizedFriend",
                dialogue = [
                    new(new Wait{secs = 1.5}),
                    new(AmVic, "pressured", "Thanks. Being crystalized was not on my bucket list.")
                ]
            }},
            {"LoseCharacterCard_No", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "panic", "Little rattled, but I'll be fine.")
                ]
            }},
            {"LoseCharacterCard", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "determined", "Status report!")
                ]
            }},
            {$"LoseCharacterCard_{AmVic}", new(){
                type = NodeType.@event,
                allPresent = [ AmVic ],
                oncePerRun = true,
                bg = "BGSupernova",
                dialogue = [
                    new(AmVic, "panic", "That was too close.")
                ]
            }},
            {"DraculaTime", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "pressured", "Who is Dracula, again?")
                ]
            }},
            {"AbandonedShipyard_Repaired", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "observe", "Hand me that rag? My feathers are dirty.")
                ]
            }},
            {"EphemeralCardGift", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "squint", "I've got a pounding headache.")
                ]
            }},
            {"ForeignCardOffering_After", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "observe", "I suppose we need all the help we can get.")
                ]
            }},
            {"ForeignCardOffering_Refuse", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "annoyed", "I've had enough of the mind games, thanks.")
                ]
            }},
            {"GrandmaShop", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "happy", "Apple pie.")
                ]
            }},
            {"Knight_1", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "determined", "You aren't prepared for us.")
                ]
            }},
            {"Sasha_2_Multi_2", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "annoyed", "Is this some kind of game to you?")
                ]
            }},
            {"SogginsEscape_1", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "annoyed", "Really?")
                ]
            }},
            {"Soggins_Infinite", new(){
                edit = [
                    new(EMod.countFromStart, 1, AmVic, "annoyed", "You're clearly not seeker certified.")
                ]
            }},
        });
    }
}