using FSPRO;
using HarmonyLib;
using JetBrains.Annotations;
using Nanoray.PluginManager;
using Nickel;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using VicCharacter.Cards;
using VicCharacter.External;
using static VicCharacter.External.IKokoroApi.IV2;
using static VicCharacter.External.IKokoroApi.IV2.IStatusLogicApi;
using static VicCharacter.External.IKokoroApi.IV2.IStatusLogicApi.IHook;

namespace VicCharacter.Features;

public sealed class ExhaustCardBrowseAction : CardAction
{
    public required List<CardAction>? OnSuccess;
    public int CardCost;
    public override void Begin(G g, State s, Combat c)
    {
        base.Begin(g, s, c);
        if (selectedCard is null)
            return;

        CardCost = selectedCard.GetCurrentCost(s);

        c.QueueImmediate([
            new AFixedExhaustOtherCard { uuid = selectedCard.uuid },
                ..(OnSuccess ?? [])
        ]);
    }
}

public sealed class AFixedExhaustOtherCard : AExhaustOtherCard
{
    public override void Begin(G g, State s, Combat c)
    {
        timer = 0.0;
        if (s.FindCard(uuid) is not { } card)
            return;

        card.ExhaustFX();
        Audio.Play(Event.CardHandling);
        s.RemoveCardFromWhereverItIs(uuid);
        c.SendCardToExhaust(s, card);
        timer = 0.3;
    }
}






