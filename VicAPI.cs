using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter;

public interface IVicApi 
{
    IDeckEntry VicCharacter { get; }
    IStatusEntry VicAuxPower { get; }
    IStatusEntry VicAuxSurge { get; }
    IStatusEntry VicRowControlStatus { get; }
    StuffBase VicTorpedo { get; }
    StuffBase EngineBooster { get; }
    StuffBase VicHeavySeeker { get; }
    StuffBase VicHURT { get; }
    StuffBase VicPAIN { get; }
    StuffBase KineticBarrier { get; }
    StuffBase ShifterDroneLeft { get; }
    StuffBase ShifterDroneUpgradedLeft { get; }
    StuffBase SignalAmplifier { get; }
    StuffBase SignalAmplifierUpgraded { get; }
    StuffBase VicSmallSpaceMine { get; }

}