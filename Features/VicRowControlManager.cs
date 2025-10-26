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


public class VicRowControlStatusManager : IKokoroApi.IV2.IStatusLogicApi.IHook, IKokoroApi.IV2.IStatusRenderingApi.IHook
{

    public VicRowControlStatusManager() 
    {
        ModEntry.Instance.KokoroApi.StatusLogic.RegisterHook(this, 0);
        ModEntry.Instance.KokoroApi.StatusRendering.RegisterHook(this, 0);
    }

    public bool HandleStatusTurnAutoStep(IHandleStatusTurnAutoStepArgs args)
    {
        if (args.Status != ModEntry.Instance.VicRowControlStatus.Status)
            return false;
        if (args.Timing != StatusTurnTriggerTiming.TurnStart)
            return false;
        if (args.Amount > 0)
        {
            args.Combat.QueueImmediate(
                new AStatus()
                {
                    status = Status.droneShift,
                    statusAmount = args.Amount,
                    targetPlayer = true
                });
        }
        return false;
    }
}

   


    
