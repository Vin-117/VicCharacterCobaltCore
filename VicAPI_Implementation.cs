using Nickel;
using VicCharacter.Midrow;

namespace VicCharacter;


public sealed class VicAPI_Implementation : IVicApi
{

    public IDeckEntry VicCharacter
        => ModEntry.Instance.VicCharacter;

    public IStatusEntry VicAuxPower
        => ModEntry.Instance.VicAuxPower;

    public IStatusEntry VicAuxSurge
        => ModEntry.Instance.VicAuxSurge;

    public IStatusEntry VicRowControlStatus
        => ModEntry.Instance.VicRowControlStatus;

    public StuffBase VicTorpedo
        => new VicTorpedo();

    public StuffBase EngineBooster
        => new EngineBooster();

    public StuffBase VicHeavySeeker
        => new VicHeavySeeker();

    public StuffBase VicHURT
        => new VicHURT();

    public StuffBase VicPAIN
        => new VicPAIN();

    public StuffBase KineticBarrier
        => new KineticBarrier();

    public StuffBase ShifterDroneLeft
        => new ShifterDroneLeft();

    public StuffBase ShifterDroneUpgradedLeft
        => new ShifterDroneUpgradedLeft();

    public StuffBase SignalAmplifier
        => new SignalAmplifier();

    public StuffBase SignalAmplifierUpgraded
        => new SignalAmplifierUpgraded();

    public StuffBase VicSmallSpaceMine
        => new VicSmallSpaceMine();
}