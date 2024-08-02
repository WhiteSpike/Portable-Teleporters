namespace PortableTeleporters.Behaviour
{
    internal class PortableTeleporter : BasePortableTeleporter
    {
        public override void Start()
        {
            base.Start();
            breakChance = Plugin.Config.PORTABLE_CHANCE_TO_BREAK;
            keepItems = Plugin.Config.PORTABLE_KEEP_ITEMS_ON_TELEPORT;
            useCooldown = Plugin.Config.PORTABLE_USE_COOLDOWN;
        }
    }
}
