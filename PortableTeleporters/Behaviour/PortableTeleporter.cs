namespace PortableTeleporters.Behaviour
{
    internal class PortableTeleporter : BasePortableTeleporter
    {
        protected override bool KeepScanNode
        {
            get
            {
                return Plugin.Config.PORTABLE_SCAN_NODE;
            }
        }
        public override void Start()
        {
            base.Start();
            breakChance = 1f - Plugin.Config.PORTABLE_CHANCE_TO_BREAK;
            keepItems = Plugin.Config.PORTABLE_KEEP_ITEMS_ON_TELEPORT;
            useCooldown = Plugin.Config.PORTABLE_USE_COOLDOWN;
        }
    }
}
