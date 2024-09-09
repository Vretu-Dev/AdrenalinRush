using System;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace AdrenalinRush {
    public class AdrenalinRush : Plugin<Config>
    {
        public override string Name => "Adrenalin Rush";
        public override string Author => "Vretu";
        public override string Prefix { get; } = "AR";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 9, 8);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.UsedItem += OnUsedItem;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.UsedItem -= OnUsedItem;
            base.OnDisabled();
        }

        private void OnUsedItem(UsedItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.Adrenaline)
            {
                ev.Player.EnableEffect(EffectType.MovementBoost, Config.BoostIntensity, Config.BoostDuration);
            }
        }
    }
}