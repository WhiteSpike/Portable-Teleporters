using CustomItemBehaviourLibrary.AbstractItems;
using System.Collections;
using UnityEngine;

namespace PortableTeleporters.Behaviour
{
    internal abstract class BasePortableTeleporter : PortableTeleporterBehaviour
    {
        /// <summary>
        /// Sounds played when interacting with the portable teleporter
        /// </summary>
        public AudioClip ItemBreak, error, buttonPress;
        /// <summary>
        /// Source of the sounds played
        /// </summary>
        private AudioSource audio;
        /// <summary>
        /// Chance of the portable teleporter breaking when activated
        /// </summary>
        protected float breakChance;

        protected abstract bool KeepScanNode { get; }

        public override void Start()
        {
            base.Start();
            if (!KeepScanNode) Destroy(gameObject.GetComponentInChildren<ScanNodeProperties>());
            audio = GetComponent<AudioSource>();
            ItemBreak = Plugin.ItemBreak;
            error = Plugin.Error;
            buttonPress = Plugin.ButtonPress;
        }

        protected override void TeleportPlayer(int playerRadarIndex, ref ShipTeleporter teleporter)
        {
            base.TeleportPlayer(playerRadarIndex, ref teleporter);
            if (playerRadarIndex == -1 && UnityEngine.Random.Range(0f, 1f) > breakChance)
            {
                audio.PlayOneShot(ItemBreak);
                itemUsedUp = true;
                HUDManager.Instance.DisplayTip("TELEPORTER BROKE!", "The teleporter button has suffered irreparable damage and destroyed itself!", true, false, "LC_Tip1");
                playerHeldBy.DespawnHeldObject();
            }
        }

        protected override IEnumerator WaitToTP(ShipTeleporter tele)
        {
            yield return StartCoroutine(base.WaitToTP(tele));
            if (UnityEngine.Random.Range(0f, 1f) > breakChance)
            {
                audio.PlayOneShot(ItemBreak);
                itemUsedUp = true;
                HUDManager.Instance.DisplayTip("TELEPORTER BROKE!", "The teleporter button has suffered irreparable damage and destroyed itself!", true, false, "LC_Tip1");
                playerHeldBy.DespawnHeldObject();
            }
        }

        protected override bool CanUsePortableTeleporter()
        {
            audio.PlayOneShot(buttonPress);
            bool result = base.CanUsePortableTeleporter();
            if (!result) audio.PlayOneShot(error);
            return result;
        }
    }
}
