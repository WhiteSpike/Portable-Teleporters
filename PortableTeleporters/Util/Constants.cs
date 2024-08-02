using PortableTeleporters;
namespace ShoppingCart.Util
{
    internal static class Constants
    {
        internal const string ITEM_SCAN_NODE_KEY_FORMAT = "Enable scan node of {0}";
        internal const bool ITEM_SCAN_NODE_DEFAULT = true;
        internal const string ITEM_SCAN_NODE_DESCRIPTION = "Shows a scan node on the item when scanning";

        internal const string BREAK_CHANCE_KEY = "Chance to break on use";
        internal const string BREAK_CHANCE_DESCRIPTION = "value should be 0.00 - 1.00";

        internal const string KEEP_ITEMS_DESCRIPTION = "If set to false you will drop your items like when using the vanilla TP.";

        internal const string PORTABLE_TELEPORTER_PRICE_KEY = $"{Plugin.PORTABLE_ITEM_NAME} price";
        internal const int PORTABLE_TELEPORTER_PRICE_DEFAULT = 500;
        internal const string PORTABLE_TELEPORTER_PRICE_DESCRIPTION = $"Price for {Plugin.PORTABLE_ITEM_NAME}.";

        internal const string PORTABLE_TELEPORTER_WEIGHT_KEY = "Item weight";
        internal const int PORTABLE_TELEPORTER_WEIGHT_DEFAULT = 15;
        internal const string PORTABLE_TELEPORTER_WEIGHT_DESCRIPTION = "Weight (in lbs)";

        internal const string PORTABLE_TELEPORTER_TWO_HANDED_KEY = "Two Handed Item";
        internal const bool PORTABLE_TELEPORTER_TWO_HANDED_DEFAULT = false;
        internal const string PORTABLE_TELEPORTER_TWO_HANDED_DESCRIPTION = "One or two handed item.";

        internal const string PORTABLE_TELEPORTER_CONDUCTIVE_KEY = "Conductive";
        internal const bool PORTABLE_TELEPORTER_CONDUCTIVE_DEFAULT = true;
        internal const string PORTABLE_TELEPORTER_CONDUCTIVE_DESCRIPTION = "Wether it attracts lightning to the item or not. (Or other mechanics that rely on item being conductive)";

        internal const string PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_KEY = "Drop ahead of player when dropping";
        internal const bool PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DEFAULT = true;
        internal const string PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DESCRIPTION = "If on, the item will drop infront of the player. Otherwise, drops underneath them and slightly infront.";

        internal const string PORTABLE_TELEPORTER_GRABBED_BEFORE_START_KEY = "Grabbable before game start";
        internal const bool PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DEFAULT = true;
        internal const string PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DESCRIPTION = "Allows wether the item can be grabbed before hand or not";

        internal const string PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_KEY = "Highest Sale Percentage";
        internal const int PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DEFAULT = 50;
        internal const string PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DESCRIPTION = "Maximum percentage of sale allowed when this item is selected for a sale.";

        internal const string PORTABLE_TELEPORTER_BREAK_CHANCE_KEY = BREAK_CHANCE_KEY;
        internal const float PORTABLE_TELEPORTER_BREAK_CHANCE_DEFAULT = 0.9f;
        internal const string PORTABLE_TELEPORTER_BREAK_CHANCE_DESCRIPTION = BREAK_CHANCE_DESCRIPTION;

        internal const string PORTABLE_TELEPORTER_KEEP_ITEMS_KEY = $"Keep Items When Using {Plugin.PORTABLE_ITEM_NAME}s";
        internal const bool PORTABLE_TELEPORTER_KEEP_ITEMS_DEFAULT = true;
        internal const string PORTABLE_TELEPORTER_KEEP_ITEMS_DESCRIPTION = KEEP_ITEMS_DESCRIPTION;

        internal const string PORTABLE_TELEPORTER_USE_COOLDOWN_KEY = "Use Cooldown";
        internal const float PORTABLE_TELEPORTER_USE_COOLDOWN_DEFAULT = 2f;
        internal const string PORTABLE_TELEPORTER_USE_COOLDOWN_DESCRIPTION = $"How long between interactions of the {Plugin.PORTABLE_ITEM_NAME} item";

        internal const string ADVANCED_PORTABLE_TELEPORTER_PRICE_KEY = $"{Plugin.ADVANCED_PORTABLE_ITEM_NAME} price";
        internal const int ADVANCED_PORTABLE_TELEPORTER_PRICE_DEFAULT = 1000;
        internal const string ADVANCED_PORTABLE_TELEPORTER_PRICE_DESCRIPTION = $"Price for {Plugin.ADVANCED_PORTABLE_ITEM_NAME}.";

        internal const string ADVANCED_PORTABLE_TELEPORTER_WEIGHT_KEY = "Item weight";
        internal const int ADVANCED_PORTABLE_TELEPORTER_WEIGHT_DEFAULT = 5;
        internal const string ADVANCED_PORTABLE_TELEPORTER_WEIGHT_DESCRIPTION = "Weight (in lbs)";

        internal const string ADVANCED_PORTABLE_TELEPORTER_TWO_HANDED_KEY = "Two Handed Item";
        internal const bool ADVANCED_PORTABLE_TELEPORTER_TWO_HANDED_DEFAULT = false;
        internal const string ADVANCED_PORTABLE_TELEPORTER_TWO_HANDED_DESCRIPTION = "One or two handed item.";

        internal const string ADVANCED_PORTABLE_TELEPORTER_CONDUCTIVE_KEY = "Conductive";
        internal const bool ADVANCED_PORTABLE_TELEPORTER_CONDUCTIVE_DEFAULT = true;
        internal const string ADVANCED_PORTABLE_TELEPORTER_CONDUCTIVE_DESCRIPTION = "Wether it attracts lightning to the item or not. (Or other mechanics that rely on item being conductive)";

        internal const string ADVANCED_PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_KEY = "Drop ahead of player when dropping";
        internal const bool ADVANCED_PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DEFAULT = true;
        internal const string ADVANCED_PORTABLE_TELEPORTER_DROP_AHEAD_PLAYER_DESCRIPTION = "If on, the item will drop infront of the player. Otherwise, drops underneath them and slightly infront.";

        internal const string ADVANCED_PORTABLE_TELEPORTER_GRABBED_BEFORE_START_KEY = "Grabbable before game start";
        internal const bool ADVANCED_PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DEFAULT = true;
        internal const string ADVANCED_PORTABLE_TELEPORTER_GRABBED_BEFORE_START_DESCRIPTION = "Allows wether the item can be grabbed before hand or not";

        internal const string ADVANCED_PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_KEY = "Highest Sale Percentage";
        internal const int ADVANCED_PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DEFAULT = 50;
        internal const string ADVANCED_PORTABLE_TELEPORTER_HIGHEST_SALE_PERCENTAGE_DESCRIPTION = "Maximum percentage of sale allowed when this item is selected for a sale.";

        internal const string ADVANCED_PORTABLE_TELEPORTER_BREAK_CHANCE_KEY = BREAK_CHANCE_KEY;
        internal const float ADVANCED_PORTABLE_TELEPORTER_BREAK_CHANCE_DEFAULT = 0.1f;
        internal const string ADVANCED_PORTABLE_TELEPORTER_BREAK_CHANCE_DESCRIPTION = BREAK_CHANCE_DESCRIPTION;

        internal const string ADVANCED_PORTABLE_TELEPORTER_KEEP_ITEMS_KEY = $"Keep Items When Using {Plugin.ADVANCED_PORTABLE_ITEM_NAME}s";
        internal const bool ADVANCED_PORTABLE_TELEPORTER_KEEP_ITEMS_DEFAULT = true;
        internal const string ADVANCED_PORTABLE_TELEPORTER_KEEP_ITEMS_DESCRIPTION = KEEP_ITEMS_DESCRIPTION;

        internal const string ADVANCED_PORTABLE_TELEPORTER_USE_COOLDOWN_KEY = "Use Cooldown";
        internal const float ADVANCED_PORTABLE_TELEPORTER_USE_COOLDOWN_DEFAULT = 2f;
        internal const string ADVANCED_PORTABLE_TELEPORTER_USE_COOLDOWN_DESCRIPTION = $"How long between interactions of the {Plugin.ADVANCED_PORTABLE_ITEM_NAME} item";

        internal static readonly string PORTABLE_TELEPORTER_SCAN_NODE_KEY = string.Format(ITEM_SCAN_NODE_KEY_FORMAT, Plugin.PORTABLE_ITEM_NAME);

        internal static readonly string ADVANCED_PORTABLE_TELEPORTER_SCAN_NODE_KEY = string.Format(ITEM_SCAN_NODE_KEY_FORMAT, Plugin.ADVANCED_PORTABLE_ITEM_NAME);
    }
}
