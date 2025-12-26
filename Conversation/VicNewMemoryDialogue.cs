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

internal class VicNewMemoryDialogue : IRegisterable
{
    public static void Register(IPluginPackage<IModManifest> package, IModHelper helper)
    {
        LocalDB.DumpStoryToLocalLocale("en", "TheJazMaster.Nibbs", new Dictionary<string, DialogueMachine>(){
            {"RunWinWho_Vic_1", new(){
                type = NodeType.@event,
                introDelay = false,
                allPresent = [ AmVic ],
                bg = "BGRunWin",
                lookup = [
                    $"runWin_{AmVic}"
                ],
                dialogue = [
                    new(new Wait{secs = 3}),
                    new(AmVic, "squint", "Where am I?"),
                    new(AmVoid, "Inside the singularity.", flipped: true),
                    new(AmVic, "pressured", "Who are you?"),
                    new(AmVic, "pressured", "Are you inside my head?"),
                    new(AmVoid, "Yes.", flipped: true),
                    new(AmVoid, "I am here to repair your timestream.", flipped: true),
                    new(AmVoid, "To restore your memory.", flipped: true),
                    new(AmVic, "pressuredneutral", "...How?"),
                    new(AmVoid, "I will show you.", flipped: true),
                ]
            }},

            {"RunWinWho_Vic_2", new(){
                type = NodeType.@event,
                introDelay = false,
                allPresent = [ AmVic ],
                bg = "BGRunWin",
                lookup = [
                    $"runWin_{AmVic}"
                ],
                requiredScenes = [
                    "RunWinWho_Vic_1"
                ],
                dialogue = [
                    new(new Wait{secs = 3}),
                    new(AmVic, "neutraltalk", "Are you the reason I'm here?"),
                    new(AmVoid, "Yes.", flipped: true),
                    new(AmVoid, "And no.", flipped: true),
                    new(AmVic, "neutraltalk", "Elaborate."),
                    new(AmVoid, "I draw you here every loop.", flipped: true),
                    new(AmVoid, "But I am not the reason this tangled timestream exists.", flipped: true),
                    new(AmVic, "neutraltalk", "Who IS responsible?"),
                    new(AmVoid, "You already know the answer to that question.", flipped: true),
                    new(AmVic, "pressured", "...What? I..."),
                    new(AmVic, "pressuredneutral", "I..."),
                    new(AmVic, "pensive", "...I see."),
                ]
            }},

            {"RunWinWho_Vic_3", new(){
                type = NodeType.@event,
                introDelay = false,
                allPresent = [ AmVic ],
                bg = "BGRunWin",
                lookup = [
                    $"runWin_{AmVic}"
                ],
                requiredScenes = [
                    "RunWinWho_Vic_2"
                ],
                dialogue = [
                    new(new Wait{secs = 3}),
                    new(AmVic, "pensive", "I understand, now."),
                    new(AmVoid, "Good. We are almost out of time.", flipped: true),
                    new(AmVic, "neutraltalk", "May I ask you one final question?"),
                    new(AmVoid, "You may.", flipped: true),
                    new(AmVic, "neutraltalk", "Why?"),
                    new(AmVoid, "...What?", flipped: true),
                    new(AmVic, "observe", "All these loops, all these resets..."),
                    new(AmVic, "neutraltalk", "Why do you help us? Why do you care?"),
                    new(AmVic, "observe", "...How do you know us?"),
                    new(AmVoid, "...", flipped: true),
                    new(AmVoid, "I cannot answer that.", flipped: true),
                ]
            }},

            {"Vic_Memory_1", new(){
                type = NodeType.@event,
                introDelay = false,
                bg = "BGVault",
                lookup = [
                    "vault", $"vault_{AmVic}"
                ],
                dialogue = [
                    new("T-100 days"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new Wait{secs = 1}),
                    new(AmVic, "pensive", "..."),
                ]
            }},

            {"Vic_Memory_2", new(){
                type = NodeType.@event,
                introDelay = false,
                bg = "BGVault",
                lookup = [
                    "vault", $"vault_{AmVic}"
                ],
                dialogue = [
                    new("T-100 days"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new Wait{secs = 1}),
                    new(AmVic, "pensive", "..."),
                ]
            }},

            {"Vic_Memory_3", new(){
                type = NodeType.@event,
                introDelay = false,
                bg = "BGVault",
                lookup = [
                    "vault", $"vault_{AmVic}"
                ],
                dialogue = [
                    new("T-100 days"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new Wait{secs = 1}),
                    new(AmVic, "pensive", "..."),
                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}