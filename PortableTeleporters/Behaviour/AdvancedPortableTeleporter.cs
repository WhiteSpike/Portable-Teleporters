namespace PortableTeleporters.Behaviour
{
    internal class AdvancedPortableTeleporter : BasePortableTeleporter
    {
        protected override bool KeepScanNode
        {
            get
            {
                return Plugin.Config.ADVANCED_PORTABLE_SCAN_NODE;
            }
        }

        public override void Start()
        {
            base.Start();
            breakChance = Plugin.Config.ADVANCED_PORTABLE_CHANCE_TO_BREAK;
            keepItems = Plugin.Config.ADVANCED_PORTABLE_KEEP_ITEMS_ON_TELEPORT;
            useCooldown = Plugin.Config.ADVANCED_PORTABLE_USE_COOLDOWN;
        }
    }
}
