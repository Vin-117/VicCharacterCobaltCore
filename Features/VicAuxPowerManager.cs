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
using VicCharacter.Actions;
using static VicCharacter.External.IKokoroApi.IV2;
using static VicCharacter.External.IKokoroApi.IV2.IStatusLogicApi;
using static VicCharacter.External.IKokoroApi.IV2.IStatusLogicApi.IHook;

namespace VicCharacter.Features;


public class VicAuxPowerStatusManager : IKokoroApi.IV2.IStatusLogicApi.IHook, IKokoroApi.IV2.IStatusRenderingApi.IHook
{
    //internal static IStatusEntry VicAuxPower { get; private set; } = null!;

    public VicAuxPowerStatusManager()
    {
        ModEntry.Instance.KokoroApi.StatusLogic.RegisterHook(this, 0);
        ModEntry.Instance.KokoroApi.StatusRendering.RegisterHook(this, 0);
    }

    public IReadOnlyList<Tooltip> OverrideStatusTooltips(IKokoroApi.IV2.IStatusRenderingApi.IHook.IOverrideStatusTooltipsArgs args)
        => args.Status == ModEntry.Instance.VicAuxPower.Status
            ?[
                .. args.Tooltips,
                new TTCard { card = new VicAux() }
            ] : args.Tooltips;
        

    public bool HandleStatusTurnAutoStep(IHandleStatusTurnAutoStepArgs args)
    {

        if (args.Status != ModEntry.Instance.VicAuxPower.Status)
            return false;
        if (args.Timing != StatusTurnTriggerTiming.TurnStart)
            return false;
        if (args.Amount > 0)
        {
            args.Combat.QueueImmediate(
                new AAddCard()
                {
                    card = new VicAux()
                    {
                    },
                    destination = CardDestination.Hand,
                    amount = args.Amount,
                });
        }
        return false;
    }
}

   


    
