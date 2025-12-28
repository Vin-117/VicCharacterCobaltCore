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
                    new(AmVic, "squint", "I...I remember now."),
                    new(AmVic, "squint", "That...that damn client."),
                    new(AmVic, "pensive", "I shouldn't have signed that contract."),
                    new(AmVoid, "This is no place for regret.", flipped: true),
                    new(AmVic, "pensive", "There is never a place for it."),
                    new(AmVic, "depressed", "But there is always time to accumulate it."),
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
                    new(AmVic, "neutraltalk", "It finally makes sense."),
                    new(AmVic, "observe", "You're the void creature. The one that was inside the time crystal."),
                    new(AmVoid, "Correct.", flipped: true),
                    new(AmVic, "annoyed", "I knew it."),
                    new(AmVic, "annoyed", "I should've seen this sooner."),
                    new(AmVoid, "You had no memory.", flipped: true),
                    new(AmVic, "doubtful", "Not that."),
                    new(AmVic, "neutraltalk", "I failed to realize that you were the entire point of the Cobalt project."),
                    new(AmVic, "neutraltalk", "Forget the ship. The client wanted their hands on a god."),
                    new(AmVoid, "They failed.", flipped: true),
                    new(AmVic, "pensive", "For now.")
                ]
            }},

            {"Vic_Memory_1", new(){
                type = NodeType.@event,
                introDelay = false,
                bg = "BGVicVault",
                lookup = [
                    "vault", $"vault_{AmVic}"
                ],
                dialogue = [
                    new("T-310 days"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new Wait{secs = 3}),
                    new(AmClient, "client_neutral", "Status report."),
                    new(AmVic, "pda", "I have a visual on the Cobalt.", flipped: true),
                    new(AmVic, "pda", "No other warp core signatures within 10 parsecs.", flipped: true),
                    new(AmVic, "pda", "For now, the Cobalt remains undetected.", flipped: true),
                    new(AmClient, "client_neutral", "Good."),
                    new(AmClient, "client_neutral", "Maintain your orbit. You will receive instructions within the next solar day."),
                    new(AmVic, "observe", "Should I not board?", flipped: true),
                    new(AmClient, "client_neutral", "No."),
                    new(AmClient, "client_neutral", "You are not to enter the ship under any circumstance."),
                    new(AmVic, "neutraltalk", "Understood.", flipped: true),
                ]
            }},

            {"Vic_Memory_2", new(){
                type = NodeType.@event,
                introDelay = false,
                bg = "BGVicVaultSecond",
                lookup = [
                    "vault", $"vault_{AmVic}"
                ],
                dialogue = [
                    new("T-300 days"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new Wait{secs = 3}),
                    new(AmVic, "neutraltalk", "Hyperia."),
                    new(AmPeri, "Sir.", flipped: true),
                    new(AmVic, "neutraltalk", "A pleasure to meet you. Your reputation precedes you."),
                    new(AmPeri, "nap", "Thank you.", flipped: true),
                    new(AmVic, "neutraltalk", "I'll keep this short."),
                    new(AmVic, "neutraltalk", "This ship you see? It's called the Cobalt. The client needs us to get it running again."),
                    new(AmPeri, "It's broken?", flipped: true),
                    new(AmVic, "neutraltalk", "Life support and other basic functions work, but the ship won't move."),
                    new(AmPeri, "squint", "Then why hire me? I'm a soldier. Not a ship mechanic.", flipped: true),
                    new(AmVic, "neutraltalk", "You'll be in charge of the crew."),
                    new(AmVic, "observe", "...And hiring them, as a matter of fact."),
                    new(AmVic, "pda", "I'm sending you dossiers on three people, along with some money."),
                    new(AmVic, "pda", "With the amount offered, you will have no problem bringing them onboard."),
                    new(AmPeri, "squint", "Just three?", flipped: true),
                    new(AmVic, "neutraltalk", "That's correct. Only three, plus yourself."),
                    new(AmVic, "observe", "The client is...secretative. And specific in their instruction."),
                    new(AmPeri, "You won't be onboard?", flipped: true),
                    new(AmVic, "neutraltalk", "No."),
                    new(AmVic, "neutraltalk", "I will be in a small monitoring ship a small distance away."),
                    new(AmVic, "neutraltalk", "As far as the rest of the crew is concerned, I don't exist."),
                    new(AmPeri, "Understood.", flipped: true),
                    new(AmVic, "pda", "Good. I'm sending you an onboarding packet."),
                    new(AmVic, "pda", "It contains the fine details of your contract and everything else relevant to your position."),
                    new(AmVic, "neutraltalk", "This information is on a need-to-know basis. Keep it under wraps."),
                    new(AmPeri, "Yes sir.", flipped: true),
                ]
            }},

            {"Vic_Memory_3", new(){
                type = NodeType.@event,
                introDelay = false,
                bg = "BGVicVaultThird",
                lookup = [
                    "vault", $"vault_{AmVic}"
                ],
                dialogue = [
                    new("T-3 hours"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new Wait{secs = 3}),
                    new(AmClient, "client_neutral", "This research is a neccessary evil."),
                    new(AmClient, "client_neutral", "You have no idea what's at stake."),
                    new(AmVic, "annoyed", "Like I haven't heard that before.", flipped: true),
                    new(AmVic, "annoyed", "What the hell are you doing?!", flipped: true),
                    new(AmVic, "pda", "When the void creature escapes from the core, it'll...", flipped: true),
                    new(AmClient, "client_neutral", "It won't."),
                    new(AmClient, "client_neutral", "The core was designed for that eventuality."),
                    new(AmVic, "doubtful", "You don't 'design' around a god.", flipped: true),
                    new(AmVic, "annoyed", "Shut it down.", flipped: true),
                    new(AmClient, "client_neutral", "Denied."),
                    new(AmClient, "client_neutral", "Continue with your duties as assigned. I will hear no more of this."),
                    new(new Wait{secs = 3}),
                    new(AmVic, "pensive", "*Sigh*"),
                    new(AmVic, "annoyed", "Bloody idiot."),
                    new("T-90 seconds"),
                    new(new Wait{secs = 2}),
                    new(title: null),  // Clears title card
                    new(new BGAction{action = "vic_transition_cutscene"}),
                    new(new Wait{secs = 3}),
                    new(AmVic, "pda", "Hyperia, come in."),
                    new(AmPeri, "Sir.", flipped: true),
                    new(AmVic, "neutraltalk", "Prepare one of the loading bays. I need to talk to you directly."),
                    new(AmPeri, "squint", "By your own order you aren't supposed to be onboard.", flipped: true),
                    new(AmVic, "observe", "Yes. But circumstances have changed."),
                    new(AmVic, "neutraltalk", "Gather the crew. You're in immense danger."),
                    new(new BGAction{action = "vic_trigger_alarm"}),
                    new(new Wait{secs = 3}),
                    new(AmPeri, "-lr-ght. I’ll ---l a -e--ing.", flipped: true),
                    new(AmVic, "pda", "Hyperia? Your signal is breaking up."),
                    new(new Wait{secs = 3}),
                    new(AmPeri, "panic", "S-r?! -’- d-t--t--g a m-ltd--n in -h- -or-!", flipped: true),
                    new(AmVic, "pdapressured", "Hyperia? What the hell is going on?!"),
                    new(new Wait{secs = 3}),
                    new(AmVic, "pressuredneutral", "Sensor overload?! How..."),
                    new(AmVic, "panic", "The core..!"),
                    new(new BGAction{action = "vic_exploded"}),
                    new(new Wait{secs = 5}),
                    new(new BGAction{action = "vic_killfx"}),
                    new("<c=downside>T-0 seconds</c>"),
                    new(new Wait{secs = 7})

                ]
            }},

            // {"", new(){

            //     dialogue = [

            //     ]
            // }},
        });
    }
}