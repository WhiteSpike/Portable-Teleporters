using BepInEx.Configuration;
using CSync.Extensions;
using CSync.Lib;
using ShoppingCart.Util;
using System.Runtime.Serialization;
using PortableTeleporters;

namespace PortableTeleporters.Misc
{
    [DataContract]
    public class PluginConfig : SyncedConfig2<PluginConfig>
    {
        [field: SyncedEntryField] public SyncedEntry<bool> PORTABLE_SCAN_NODE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<int> PORTABLE_PRICE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<int> PORTABLE_WEIGHT { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> PORTABLE_DROP_AHEAD_PLAYER { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> PORTABLE_GRABBED_BEFORE_START { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> PORTABLE_CONDUCTIVE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> PORTABLE_TWO_HANDED { get; set; }
        [field: SyncedEntryField] public SyncedEntry<int> PORTABLE_HIGHEST_SALE_PERCENTAGE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<float> PORTABLE_CHANCE_TO_BREAK { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> PORTABLE_KEEP_ITEMS_ON_TELEPORT { get; set; }
        [field: SyncedEntryField] public SyncedEntry<float> PORTABLE_USE_COOLDOWN { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> ADVANCED_PORTABLE_SCAN_NODE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<int> ADVANCED_PORTABLE_PRICE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<int> ADVANCED_PORTABLE_WEIGHT { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> ADVANCED_PORTABLE_TWO_HANDED { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> ADVANCED_PORTABLE_DROP_AHEAD_PLAYER { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> ADVANCED_PORTABLE_GRABBED_BEFORE_START { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> ADVANCED_PORTABLE_CONDUCTIVE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<int> ADVANCED_PORTABLE_HIGHEST_SALE_PERCENTAGE { get; set; }
        [field: SyncedEntryField] public SyncedEntry<float> ADVANCED_PORTABLE_CHANCE_TO_BREAK { get; set; }
        [field: SyncedEntryField] public SyncedEntry<bool> ADVANCED_PORTABLE_KEEP_ITEMS_ON_TELEPORT { get; set; }
        [field: SyncedEntryField] public SyncedEntry<float> ADVANCED_PORTABLE_USE_COOLDOWN { get; set; }
        public PluginConfig(ConfigFile cfg) : base(Metadata.GUID)
        {
            string topSection = Plugin.PORTABLE_ITEM_NAME;

            PORTABLE_PRICE = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_PRICE_KEY, Constants.PORTABLE_TELEPORTER_PRICE_DEFAULT, Constants.PORTABLE_TELEPORTER_PRICE_DESCRIPTION);
            PORTABLE_WEIGHT = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_WEIGHT_KEY, Constants.PORTABLE_TELEPORTER_WEIGHT_DEFAULT, Constants.PORTABLE_TELEPORTER_WEIGHT_DESCRIPTION);
            PORTABLE_SCAN_NODE = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_SCAN_NODE_KEY, Constants.ITEM_SCAN_NODE_DEFAULT, Constants.ITEM_SCAN_NODE_DESCRIPTION);
            PORTABLE_TWO_HANDED = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_TWO_HANDED_KEY, Constants.PORTABLE_TELEPORTER_TWO_HANDED_DEFAULT, Constants.PORTABLE_TELEPORTER_TWO_HANDED_DESCRIPTION);
            PORTABLE_DROP_AHEAD_PLAYER = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_KEY, Constants.PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DEFAULT, Constants.PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DESCRIPTION);
            PORTABLE_CONDUCTIVE = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_CONDUCTIVE_KEY, Constants.PORTABLE_TELEPORTER_CONDUCTIVE_DEFAULT, Constants.PORTABLE_TELEPORTER_CONDUCTIVE_DESCRIPTION);
            PORTABLE_GRABBED_BEFORE_START = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_GRABBED_BEFORE_START_KEY, Constants.PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DEFAULT, Constants.PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DESCRIPTION);
            PORTABLE_HIGHEST_SALE_PERCENTAGE = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_KEY, Constants.PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DEFAULT, Constants.PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DESCRIPTION);
            PORTABLE_CHANCE_TO_BREAK = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_BREAK_CHANCE_KEY, Constants.PORTABLE_TELEPORTER_BREAK_CHANCE_DEFAULT, Constants.PORTABLE_TELEPORTER_BREAK_CHANCE_DESCRIPTION);
            PORTABLE_KEEP_ITEMS_ON_TELEPORT = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_KEEP_ITEMS_KEY, Constants.PORTABLE_TELEPORTER_KEEP_ITEMS_DEFAULT, Constants.PORTABLE_TELEPORTER_KEEP_ITEMS_DESCRIPTION);
            PORTABLE_USE_COOLDOWN = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_USE_COOLDOWN_KEY, Constants.PORTABLE_TELEPORTER_USE_COOLDOWN_DEFAULT, Constants.PORTABLE_TELEPORTER_USE_COOLDOWN_DESCRIPTION);

            topSection = Plugin.ADVANCED_PORTABLE_ITEM_NAME;

            ADVANCED_PORTABLE_PRICE = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_PRICE_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_PRICE_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_PRICE_DESCRIPTION);
            ADVANCED_PORTABLE_WEIGHT = cfg.BindSyncedEntry(topSection, Constants.PORTABLE_TELEPORTER_WEIGHT_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_WEIGHT_DEFAULT, Constants.PORTABLE_TELEPORTER_WEIGHT_DESCRIPTION);
            ADVANCED_PORTABLE_SCAN_NODE = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_SCAN_NODE_KEY, Constants.ITEM_SCAN_NODE_DEFAULT, Constants.ITEM_SCAN_NODE_DESCRIPTION);
            ADVANCED_PORTABLE_TWO_HANDED = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_TWO_HANDED_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_TWO_HANDED_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_TWO_HANDED_DESCRIPTION);
            ADVANCED_PORTABLE_DROP_AHEAD_PLAYER = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DESCRIPTION);
            ADVANCED_PORTABLE_CONDUCTIVE = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_CONDUCTIVE_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_CONDUCTIVE_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_CONDUCTIVE_DESCRIPTION);
            ADVANCED_PORTABLE_GRABBED_BEFORE_START = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_GRABBED_BEFORE_START_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DESCRIPTION);
            ADVANCED_PORTABLE_HIGHEST_SALE_PERCENTAGE = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DESCRIPTION);
            ADVANCED_PORTABLE_CHANCE_TO_BREAK = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_BREAK_CHANCE_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_BREAK_CHANCE_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_BREAK_CHANCE_DESCRIPTION);
            ADVANCED_PORTABLE_KEEP_ITEMS_ON_TELEPORT = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_KEEP_ITEMS_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_KEEP_ITEMS_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_KEEP_ITEMS_DESCRIPTION);
            ADVANCED_PORTABLE_USE_COOLDOWN = cfg.BindSyncedEntry(topSection, Constants.ADVANCED_PORTABLE_TELEPORTER_USE_COOLDOWN_KEY, Constants.ADVANCED_PORTABLE_TELEPORTER_USE_COOLDOWN_DEFAULT, Constants.ADVANCED_PORTABLE_TELEPORTER_USE_COOLDOWN_DESCRIPTION);

            ConfigManager.Register(this);
        }
    }
}
