using BepInEx;
using BepInEx.Logging;
using PortableTeleporters.Misc;
using HarmonyLib;
using LethalLib.Modules;
using System.IO;
using System.Reflection;
using UnityEngine;
using CustomItemBehaviourLibrary.Misc;
using LethalLib.Extras;
using PortableTeleporters.Behaviour;
namespace PortableTeleporters
{
    [BepInPlugin(Metadata.GUID,Metadata.NAME,Metadata.VERSION)]
    [BepInDependency("com.sigurd.csync")]
    [BepInDependency("evaisa.lethallib")]
    [BepInDependency("com.github.WhiteSpike.CustomItemBehaviourLibrary")]
    public class Plugin : BaseUnityPlugin
    {
        internal static readonly Harmony harmony = new(Metadata.GUID);
        internal static readonly ManualLogSource mls = BepInEx.Logging.Logger.CreateLogSource(Metadata.NAME);

        internal const string PORTABLE_ITEM_NAME = "Portable Teleporter";
        internal const string ADVANCED_PORTABLE_ITEM_NAME = "Advanced Portable Teleporter";
        internal static AudioClip ItemBreak, Error, ButtonPress;

        public new static PluginConfig Config;

        void Awake()
        {
            Config = new PluginConfig(base.Config);

            string assetDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "portableteleporters");
            AssetBundle bundle = AssetBundle.LoadFromFile(assetDir);
            string root = "Assets/Portable Teleporters/";
            string portableRoot = root + "Portable Teleporter/";
            string advancedPortableRoot = root + "Advanced Portable Teleporter/";

            ItemBreak = bundle.LoadAsset<AudioClip>(root + "Break.mp3");
            Error = bundle.LoadAsset<AudioClip>(root + "Error.mp3");
            ButtonPress = bundle.LoadAsset<AudioClip>(root + "ButtonPress.ogg");

            Item portableTeleporterItem = ScriptableObject.CreateInstance<Item>();
            portableTeleporterItem.name = "PortableTeleporterItemProperties";
            portableTeleporterItem.creditsWorth = Config.PORTABLE_PRICE;
            portableTeleporterItem.allowDroppingAheadOfPlayer = Config.PORTABLE_DROP_AHEAD_PLAYER;
            portableTeleporterItem.canBeGrabbedBeforeGameStart = Config.PORTABLE_GRABBED_BEFORE_START;
            portableTeleporterItem.canBeInspected = false;
            portableTeleporterItem.floorYOffset = -90;
            portableTeleporterItem.restingRotation = new Vector3(0f, 0f, -90f);
            portableTeleporterItem.rotationOffset = new Vector3(-15f, -180f, 65f);
            portableTeleporterItem.positionOffset = new Vector3(-0.07f, 0.05f, -0.05f);
            portableTeleporterItem.weight = 0.99f + (Config.PORTABLE_WEIGHT / 100f);
            portableTeleporterItem.twoHanded = false;
            portableTeleporterItem.itemIcon = bundle.LoadAsset<Sprite>(portableRoot + "Icon.png");
            portableTeleporterItem.spawnPrefab = bundle.LoadAsset<GameObject>(portableRoot + "PortableTeleporter.prefab");
            portableTeleporterItem.dropSFX = bundle.LoadAsset<AudioClip>(root + "Drop.ogg");
            portableTeleporterItem.grabSFX = bundle.LoadAsset<AudioClip>(root + "Grab.ogg");
            portableTeleporterItem.pocketSFX = bundle.LoadAsset<AudioClip>(root + "Pocket.ogg");
            portableTeleporterItem.throwSFX = bundle.LoadAsset<AudioClip>(root + "Throw.ogg");
            portableTeleporterItem.highestSalePercentage = Config.PORTABLE_HIGHEST_SALE_PERCENTAGE;
            portableTeleporterItem.itemName = PORTABLE_ITEM_NAME;
            portableTeleporterItem.itemSpawnsOnGround = true;
            portableTeleporterItem.isConductiveMetal = Config.PORTABLE_CONDUCTIVE;
            portableTeleporterItem.requiresBattery = false;
            portableTeleporterItem.batteryUsage = 0f;

            PortableTeleporter grabbableObject = portableTeleporterItem.spawnPrefab.AddComponent<PortableTeleporter>();
            mls.LogDebug("Yay2");
            grabbableObject.itemProperties = portableTeleporterItem;
            grabbableObject.grabbable = true;
            grabbableObject.grabbableToEnemies = true;
            Utilities.FixMixerGroups(portableTeleporterItem.spawnPrefab);
            NetworkPrefabs.RegisterNetworkPrefab(portableTeleporterItem.spawnPrefab);

            TerminalNode infoNode = SetupInfoNode();
            Items.RegisterShopItem(shopItem: portableTeleporterItem, itemInfo: infoNode, price: portableTeleporterItem.creditsWorth);

            portableTeleporterItem = ScriptableObject.CreateInstance<Item>();
            portableTeleporterItem.name = "AdvancedPortableTeleporterItemProperties";
            portableTeleporterItem.creditsWorth = Config.ADVANCED_PORTABLE_PRICE;
            portableTeleporterItem.allowDroppingAheadOfPlayer = Config.PORTABLE_DROP_AHEAD_PLAYER;
            portableTeleporterItem.canBeGrabbedBeforeGameStart = Config.PORTABLE_GRABBED_BEFORE_START;
            portableTeleporterItem.canBeInspected = false;
            portableTeleporterItem.floorYOffset = -90;
            portableTeleporterItem.restingRotation = new Vector3(0f, 0f, -90f);
            portableTeleporterItem.rotationOffset = new Vector3(-15f, -180f, 65f);
            portableTeleporterItem.positionOffset = new Vector3(-0.07f, 0.05f, -0.05f);
            portableTeleporterItem.weight = 0.99f + (Config.PORTABLE_WEIGHT / 100f);
            portableTeleporterItem.twoHanded = false;
            portableTeleporterItem.itemIcon = bundle.LoadAsset<Sprite>(advancedPortableRoot + "Icon.png");
            portableTeleporterItem.spawnPrefab = bundle.LoadAsset<GameObject>(advancedPortableRoot + "AdvancedPortableTeleporter.prefab");
            portableTeleporterItem.dropSFX = bundle.LoadAsset<AudioClip>(root + "Drop.ogg");
            portableTeleporterItem.grabSFX = bundle.LoadAsset<AudioClip>(root + "Grab.ogg");
            portableTeleporterItem.pocketSFX = bundle.LoadAsset<AudioClip>(root + "Pocket.ogg");
            portableTeleporterItem.throwSFX = bundle.LoadAsset<AudioClip>(root + "Throw.ogg");
            portableTeleporterItem.highestSalePercentage = Config.PORTABLE_HIGHEST_SALE_PERCENTAGE;
            portableTeleporterItem.itemName = ADVANCED_PORTABLE_ITEM_NAME;
            portableTeleporterItem.itemSpawnsOnGround = true;
            portableTeleporterItem.isConductiveMetal = Config.PORTABLE_CONDUCTIVE;
            portableTeleporterItem.requiresBattery = false;
            portableTeleporterItem.batteryUsage = 0f;

            AdvancedPortableTeleporter advancedGrabbableObject = portableTeleporterItem.spawnPrefab.AddComponent<AdvancedPortableTeleporter>();
            advancedGrabbableObject.itemProperties = portableTeleporterItem;
            advancedGrabbableObject.grabbable = true;
            advancedGrabbableObject.grabbableToEnemies = true;
            Utilities.FixMixerGroups(portableTeleporterItem.spawnPrefab);
            NetworkPrefabs.RegisterNetworkPrefab(portableTeleporterItem.spawnPrefab);

            infoNode = SetupInfoNode();
            Items.RegisterShopItem(shopItem: portableTeleporterItem, itemInfo: infoNode, price: portableTeleporterItem.creditsWorth);

            mls.LogInfo($"{Metadata.NAME} {Metadata.VERSION} has been loaded successfully.");
        }
        internal static TerminalNode SetupInfoNode()
        {
            TerminalNode infoNode = ScriptableObject.CreateInstance<TerminalNode>();
            infoNode.displayText += GetDisplayInfo() + "\n";
            infoNode.clearPreviousText = true;
            return infoNode;
        }
        public static string GetDisplayInfo()
        {
            return string.Format("A button that when pressed teleports you and your loot back to the ship. Must have Ship Teleporter unlocked!!!\n\nHas a {0}% chance to self destruct on use.\n", PORTABLE_ITEM_NAME);
        }
    }   
}
