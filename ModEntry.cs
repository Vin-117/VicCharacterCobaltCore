using HarmonyLib;
using Microsoft.Extensions.Logging;
using Nanoray.PluginManager;
using Nickel;
using Nickel.Common;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using VicCharacter.Artifacts;
using VicCharacter.Cards;
using VicCharacter.Conversation;
using VicCharacter.External;
using VicCharacter.Features;

namespace VicCharacter;

internal class ModEntry : SimpleMod
{

    //Initiate sprite and icon variables for midrow objects.
    internal ISpriteEntry KineticBarrierMidrow { get; }
    internal ISpriteEntry KineticBarrierSmall { get; }

    internal ISpriteEntry SmallSpaceMineMidrow { get; }
    internal ISpriteEntry SmallSpaceMineSmall { get; }

    internal ISpriteEntry EngineBoosterMidrow { get; }
    internal ISpriteEntry EngineBoosterSmall { get; }

    internal ISpriteEntry SignalAmplifierMidrow { get; }
    internal ISpriteEntry SignalAmplifierSmall { get; }
    internal ISpriteEntry SignalAmplifierUpgradedMidrow { get; }
    internal ISpriteEntry SignalAmplifierUpgradedSmall { get; }

    internal ISpriteEntry TorpedoMidrow { get; }
    internal ISpriteEntry TorpedoSmall { get; }

    internal ISpriteEntry HeavySeekerMidrow { get; }
    internal ISpriteEntry HeavySeekerBlinkMidrow { get; }
    internal ISpriteEntry HeavySeekerAngledMidrow { get; }
    internal ISpriteEntry HeavySeekerAngledBlinkMidrow { get; }
    internal ISpriteEntry HeavySeekerSmall { get; }

    internal ISpriteEntry HURTMidrow { get; }
    internal ISpriteEntry HURTSmall { get; }

    internal ISpriteEntry PAINMidrow { get; }
    internal ISpriteEntry PAINSmall { get; }

    internal ISpriteEntry ShiftDroneLeft { get; }

    internal ISpriteEntry ShiftDroneLeftSmall { get; }

    internal ISpriteEntry ShiftDroneUpgradedLeft { get; }

    internal ISpriteEntry ShiftDroneUpgradedLeftSmall { get; }

    internal ISpriteEntry ShiftDroneRight { get; }

    internal ISpriteEntry ShiftDroneRightSmall { get; }

    internal ISpriteEntry ShiftDroneUpgradedRight { get; }

    internal ISpriteEntry ShiftDroneUpgradedRightSmall { get; }

    internal ISpriteEntry DummySeekerSmall { get; }


    //Initiate status variables
    internal IStatusEntry VicAuxPower;
    internal IStatusEntry VicAuxSurge;
    internal IStatusEntry VicRowControlStatus;

    internal static ModEntry Instance { get; private set; } = null!;
    internal Harmony Harmony;
    internal IKokoroApi.IV2 KokoroApi;
    internal IDeckEntry VicCharacter;
    public LocalDB localDB { get; set; } = null!;

    internal ILocalizationProvider<IReadOnlyList<string>> AnyLocalizations { get; }
    internal ILocaleBoundNonNullLocalizationProvider<IReadOnlyList<string>> Localizations { get; }

    /*
     * Register Cards and Artifacts
     */
    private static List<Type> VicCharacterCommonCardTypes = [
        typeof(VicManeuver),
        typeof(VicCalibrate),
        typeof(VicCrisisManagement),
        typeof(VicSeekerSwarm),
        typeof(VicMisdirection),
        typeof(VicShifterDroneCard),
        typeof(VicMobileMine),
        typeof(VicSignalAmplifierCard),
        typeof(VicMinefield)
    ];
    private static List<Type> VicCharacterUncommonCardTypes = [
        typeof(VicSensorOverload),
        typeof(VicCalmUnderPressure),
        typeof(VicBlockade),
        typeof(VicEngineBoosterCard),
        typeof(VicPoisonMissile),
        typeof(VicRowControl),
        typeof(VicSiphon)
    ];
    private static List<Type> VicCharacterRareCardTypes = [
        typeof(VicTorpedoCard),
        typeof(VicKineticBarrier),
        typeof(VicRemember),
        typeof(VicAuxiliaryPower),
        typeof(VicHURTCard)
    ];
    private static List<Type> VicCharacterSpecialCardTypes = [
        typeof(VicGlide),
        typeof(VicLockdown),
        typeof(VicTrapCharge),
        typeof(VicAux),
        typeof(VicPlan),
        typeof(VicThanix),
        typeof(VicDrift)
    ];
    private static List<Type> VicCharacterEXECardTypes = [
        typeof(VicCatEXE)
        ];
    private static List<Type> VicCharacterDialogueTypes = [
        typeof(VicNewCombatDialogue),
        typeof(VicNewStoryDialogue),
        typeof(VicNewEventDialogue),
        typeof(VicNewMultiDialogue)
    ];
    private static IEnumerable<Type> VicCharacterFullModCardTypes =
        VicCharacterCommonCardTypes
            .Concat(VicCharacterUncommonCardTypes)
            .Concat(VicCharacterRareCardTypes)
            .Concat(VicCharacterSpecialCardTypes)
            .Concat(VicCharacterEXECardTypes);

    private static List<Type> VicCharacterFullModCommonArtifacts = [
        typeof(VicRadioSystem),
        typeof(VicSidelink),
        typeof(VicRegenExhaust)
    ];
    private static List<Type> VicCharacterFullModBossArtifacts = [
        typeof(VicOverclockedMissileBay),
        typeof(VicLevelheaded),
        typeof(VicPowerReserve)
    ];
    private static IEnumerable<Type> VicCharacterFullModArtifactTypes =
        VicCharacterFullModCommonArtifacts
            .Concat(VicCharacterFullModBossArtifacts);

    private static IEnumerable<Type> AllRegisterableTypes =
        VicCharacterFullModCardTypes
            .Concat(VicCharacterFullModArtifactTypes)
            .Concat(VicCharacterDialogueTypes);

    public ModEntry(IPluginPackage<IModManifest> package, IModHelper helper, ILogger logger) : base(package, helper, logger)
    {
        Instance = this;
        Harmony = new Harmony("Vintage.VicCharacterFullModMod");

        //Assign sprites to icon variables
        HeavySeekerMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/missile_heavy_seeker.png"));
        HeavySeekerBlinkMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/missile_heavy_seeker_blink.png"));
        HeavySeekerAngledMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/missile_heavy_seekerAngle.png"));
        HeavySeekerAngledBlinkMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/missile_heavy_seekerAngle_blink.png"));
        HeavySeekerSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/HeavySeekerSmall.png"));
        DummySeekerSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/DummySeekerSmall.png"));

        KineticBarrierMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/KineticBarrier.png"));
        KineticBarrierSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/KineticBarrierSmall.png"));

        SmallSpaceMineMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/SmallSpaceMine.png"));
        SmallSpaceMineSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/SmallSpaceMineIcon.png"));

        EngineBoosterMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/EngineBooster.png"));
        EngineBoosterSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/EngineBoosterSmall.png"));

        SignalAmplifierMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/SignalAmplifier.png"));
        SignalAmplifierSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/SignalAmplifierSmall.png"));

        SignalAmplifierUpgradedMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/SignalAmplifier_upgraded.png"));
        SignalAmplifierUpgradedSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/SignalAmplifierSmall_upgraded.png"));

        TorpedoMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/Torpedo.png"));
        TorpedoSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/TorpedoSmall.png"));

        HURTMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/HURT.png"));
        HURTSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/HURTSmall.png"));

        PAINMidrow = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/PAIN.png"));
        PAINSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/PAINSmall.png"));

        ShiftDroneLeft = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/ShiftDroneLeft.png"));
        ShiftDroneLeftSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/ShiftDroneLeftSmall.png"));
        ShiftDroneUpgradedLeft = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/ShiftDroneLeft_upgraded.png"));
        ShiftDroneUpgradedLeftSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/ShiftDroneLeftSmall_upgraded.png"));

        ShiftDroneRight = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/ShiftDroneRight.png"));
        ShiftDroneRightSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/ShiftDroneRightSmall.png"));
        ShiftDroneUpgradedRight = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/midrow/ShiftDroneRight_upgraded.png"));
        ShiftDroneUpgradedRightSmall = helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile("assets/icon/ShiftDroneRightSmall_upgraded.png"));

        /*
         * Koroko dependency is mandatory
         */
        KokoroApi = helper.ModRegistry.GetApi<IKokoroApi>("Shockah.Kokoro")!.V2;

        AnyLocalizations = new JsonLocalizationProvider(
            tokenExtractor: new SimpleLocalizationTokenExtractor(),
            localeStreamFunction: locale => package.PackageRoot.GetRelativeFile($"i18n/{locale}.json").OpenRead()
        );
        Localizations = new MissingPlaceholderLocalizationProvider<IReadOnlyList<string>>(
            new CurrentLocaleOrEnglishLocalizationProvider<IReadOnlyList<string>>(AnyLocalizations)
        );

        helper.Events.OnModLoadPhaseFinished += (_, phase) =>
        {
            if (phase == ModLoadPhase.AfterDbInit)
            {
                localDB = new(helper, package);
            }
        };

        helper.Events.OnLoadStringsForLocale += (_, thing) =>
        {
            foreach (KeyValuePair<string, string> entry in localDB.GetLocalizationResults())
            {
                thing.Localizations[entry.Key] = entry.Value;
            }
        };

        /*
         * Define character deck
         */
        VicCharacter = helper.Content.Decks.RegisterDeck("VicCharacterFullMod", new DeckConfiguration
        {

            Definition = new DeckDef
            {
                /*
                 * Define character colour
                 */
                color = new Color("c8c8c8"),

                titleColor = new Color("000000")
            },

            DefaultCardArt = StableSpr.cards_colorless,
            BorderSprite = RegisterSprite(package, "assets/frame_vic.png").Sprite,
            Name = AnyLocalizations.Bind(["character", "name"]).Localize
        });

        helper.ModRegistry.AwaitApi<IMoreDifficultiesApi>(
            "TheJazMaster.MoreDifficulties",
            new SemanticVersion(1, 3, 0),
            api => api.RegisterAltStarters(
                deck: VicCharacter.Deck,
                starterDeck: new StarterDeck
                {
                    cards = [
                        new VicCalibrate(),
                        new VicSignalAmplifierCard(),
                    ]
                }

            )
        );

        /*
         * Initialize IRegisterable types
         */
        foreach (var type in AllRegisterableTypes)
            AccessTools.DeclaredMethod(type, nameof(IRegisterable.Register))?.Invoke(null, [package, helper]);

        /*
         * Define character sprites
         */
        RegisterAnimation(package, "neutral", "assets/Animation/Neutral/VicNeutral", 1);
        RegisterAnimation(package, "pensive", "assets/Animation/Pensive/VicPensive", 5);
        RegisterAnimation(package, "neutraltalk", "assets/Animation/Neutral/VicNeutral", 4);
        RegisterAnimation(package, "squint", "assets/Animation/Squint/VicSquint", 4);
        RegisterAnimation(package, "annoyed", "assets/Animation/Annoyed/VicAnnoyed", 4);
        RegisterAnimation(package, "doubtful", "assets/Animation/Doubtful/VicDoubtful", 4);
        RegisterAnimation(package, "happy", "assets/Animation/Happy/VicHappy", 4);
        RegisterAnimation(package, "happyneutral", "assets/Animation/HappyNeutral/VicHappyNeutral", 4);
        RegisterAnimation(package, "smug", "assets/Animation/Smug/VicSmug", 4);
        RegisterAnimation(package, "determined", "assets/Animation/Determined/VicDetermined", 4);
        RegisterAnimation(package, "panic", "assets/Animation/Panic/VicPanic", 4);
        RegisterAnimation(package, "pda", "assets/Animation/PDA/VicPDA", 4);
        RegisterAnimation(package, "pdasmile", "assets/Animation/PDASmile/VicPDASmile", 4);
        RegisterAnimation(package, "pdapressured", "assets/Animation/PDAPressured/VicPDAPressured", 4);
        RegisterAnimation(package, "observe", "assets/Animation/Observe/VicObserve", 4);
        RegisterAnimation(package, "observestatic", "assets/Animation/Observe/VicObserve", 1);
        RegisterAnimation(package, "pressured", "assets/Animation/Pressured/VicPressured", 4);
        RegisterAnimation(package, "pressuredneutral", "assets/Animation/PressuredNeutral/VicPressuredNeutral", 4);
        RegisterAnimation(package, "pressuredstatic", "assets/Animation/Pressured/VicPressured", 1);
        RegisterAnimation(package, "explains", "assets/Animation/Explains/VicExplains", 5);
        RegisterAnimation(package, "depressed", "assets/Animation/Depressed/VicDepressed", 4);
        Instance.Helper.Content.Characters.V2.RegisterCharacterAnimation(new CharacterAnimationConfigurationV2
        {
            CharacterType = VicCharacter.Deck.Key(),
            LoopTag = "gameover",
            Frames = [
                RegisterSprite(package, "assets/Animation/VicGameOver.png").Sprite,
            ]
        });
        Instance.Helper.Content.Characters.V2.RegisterCharacterAnimation(new CharacterAnimationConfigurationV2
        {
            CharacterType = VicCharacter.Deck.Key(),
            LoopTag = "mini",
            Frames = [
                RegisterSprite(package, "assets/Animation/VicCharacterMini.png").Sprite,
            ]
        });

        helper.Content.Characters.V2.RegisterPlayableCharacter("VicCharacterFullMod", new PlayableCharacterConfigurationV2
        {

            Deck = VicCharacter.Deck,
            BorderSprite = RegisterSprite(package, "assets/char_frame_vic.png").Sprite,
            Starters = new StarterDeck
            {
                cards = [
                    new VicSeekerSwarm(),
                    new VicManeuver()
                ],
            },
            SoloStarters = new StarterDeck
            {
                cards = [
                    new VicSeekerSwarm(),
                    new VicManeuver(),
                    new VicMobileMine(),
                    new VicCrisisManagement(),
                    new CannonColorless(),
                    new DodgeColorless()
                ]
            },
            Description = AnyLocalizations.Bind(["character", "desc"]).Localize
        });

        /*
         * Define Statuses
         */
        VicAuxPower = helper.Content.Statuses.RegisterStatus("VicAuxPower", new StatusConfiguration
        {
            Definition = new StatusDef
            {
                isGood = true,
                affectedByTimestop = false,
                color = new Color("92b6f0"),
                icon = RegisterSprite(package, "assets/icon/VicAux.png").Sprite
            },
            Name = AnyLocalizations.Bind(["status", "VicAuxPower", "name"]).Localize,
            Description = AnyLocalizations.Bind(["status", "VicAuxPower", "desc"]).Localize
        });
        _ = new VicAuxPowerStatusManager();

        VicAuxSurge = helper.Content.Statuses.RegisterStatus("VicAuxSurge", new StatusConfiguration
        {
            Definition = new StatusDef
            {
                isGood = true,
                affectedByTimestop = false,
                color = new Color("92b6f0"),
                icon = RegisterSprite(package, "assets/icon/VicAuxSurge.png").Sprite
            },
            Name = AnyLocalizations.Bind(["status", "VicAuxSurge", "name"]).Localize,
            Description = AnyLocalizations.Bind(["status", "VicAuxSurge", "desc"]).Localize
        });
        _ = new VicAuxSurgeStatusManager();

        VicRowControlStatus = helper.Content.Statuses.RegisterStatus("VicRowControlStatus", new StatusConfiguration
        {
            Definition = new StatusDef
            {
                isGood = true,
                affectedByTimestop = false,
                color = new Color("7a78ff"),
                icon = RegisterSprite(package, "assets/icon/VicRowControlStatus.png").Sprite
            },
            Name = AnyLocalizations.Bind(["status", "VicRowControlStatus", "name"]).Localize,
            Description = AnyLocalizations.Bind(["status", "VicRowControlStatus", "desc"]).Localize
        });

        _ = new VicRowControlStatusManager();
    }

    public static ISpriteEntry RegisterSprite(IPluginPackage<IModManifest> package, string dir)
    {
        return Instance.Helper.Content.Sprites.RegisterSprite(package.PackageRoot.GetRelativeFile(dir));
    }

    /*
     * Animation function
     */
    public static void RegisterAnimation(IPluginPackage<IModManifest> package, string tag, string dir, int frames)
    {
        Instance.Helper.Content.Characters.V2.RegisterCharacterAnimation(new CharacterAnimationConfigurationV2
        {
            CharacterType = Instance.VicCharacter.Deck.Key(),
            LoopTag = tag,
            Frames = Enumerable.Range(0, frames)
                .Select(i => RegisterSprite(package, dir + i + ".png").Sprite)
                .ToImmutableList()
        });
    }
}

