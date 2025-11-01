using System.Linq;
using Microsoft.Extensions.Logging;
using Nickel;

namespace VicCharacter.Conversation;

/// <summary>
/// For if a dialogue needs to be registered AFTER mods have been loaded
/// </summary>
internal interface IDialogueRegisterable
{
    static abstract void LateRegister();
}

static class CommonDefinitions
{
    internal static ModEntry Instance => ModEntry.Instance;

    internal static string AmVic => Instance.VicCharacter.UniqueName;
    internal static Deck AmVicDeck => Instance.VicCharacter.Deck;

    internal const string AmCat = "comp";
    internal static string AmDizzy => Deck.dizzy.Key();
    internal static string AmPeri => Deck.peri.Key();
    internal static string AmRiggs => Deck.riggs.Key();
    internal static string AmDrake => Deck.eunice.Key();
    internal static string AmIsaac => Deck.goat.Key();
    internal static string AmBooks => Deck.shard.Key();
    internal static string AmMax => Deck.hacker.Key();
    internal const string AmVoid = "void";
    internal const string AmShopkeeper = "nerd";
    internal const string AmBrimford = "walrus";

    //internal static Status MissingVic => ModEntry.VicCharacter.MissingStatus.Status;

    //internal static Status TryGetMissing(this string who)
    //{
    //    if (
    //        who is not null &&
    //        // ModEntry.Instance.Helper.Content.Decks.LookupByUniqueName(who) is IDeckEntry ide &&
    //        // ModEntry.Instance.Helper.Content.Characters.V2.LookupByDeck(ide.Deck) is IPlayableCharacterEntryV2 ipce
    //        ModEntry.Instance.Helper.Content.Characters.V2.LookupByUniqueName(who) is IPlayableCharacterEntryV2 ipce
    //        )
    //    {
    //        return ipce.MissingStatus.Status;
    //    }
    //    ModEntry.Instance.Logger.LogWarning("Couldn't find a missing!");
    //    return MissingIlleana;
    //}




    /// <summary>
    /// Converts the short name into the full name that the game will recognise
    /// </summary>
    /// <param name="Name">Name of artifact or item</param>
    /// <returns>Full name</returns>
    //internal static string F(this string Name)
    //{
    //    return $"{Instance.UniqueName}::{Name}";
    //}
}