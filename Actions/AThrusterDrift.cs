using Nanoray.PluginManager;
using Nickel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VicCharacter.External;

namespace VicCharacter.Actions;

internal sealed class AThrusterDrift : CardAction
{
    public required int cardRequirement;
    public required int evadeAmount;

    public override void Begin(G g, State s, Combat c)
    {
        base.Begin(g, s, c);
        int tempCardsAmount = 0;

        //foreach (var card in s.deck.Concat(c.hand).Concat(c.discard).Concat(c.exhausted)) 
        foreach (var card in c.hand)
        {
            if (card.GetDataWithOverrides(s).temporary) 
            {
                tempCardsAmount++;
            }
        }

        if (tempCardsAmount >= cardRequirement) 
        {
            c.Queue(new AStatus 
            {
                status = Status.evade,
                statusAmount = evadeAmount,
                targetPlayer = true
            });
        }
    }
}
