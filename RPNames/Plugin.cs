using System;
using RPNames.Handlers;
using Player = Exiled.Events.Handlers.Player;

namespace RPNames
{
    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name { get; } = "Rp Names";
        public override string Prefix { get; } = "RP Names";
        
        public override string Author { get; } = "Timersky, Original plugin by: Babyboucher20 Maintained by Enes Batur";
        
        public override Version Version { get; } = new(3, 0, 0);
        public override Version RequiredExiledVersion { get; } = new(8, 8, 0);

        private PlayerHandlers _handlers;
        
        public override void OnEnabled()
        {
            _handlers = new(this);

            Player.ChangingRole += _handlers.OnChangeRole;
            Player.Died += _handlers.OnDeath;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Died -= _handlers.OnDeath;
            Player.ChangingRole -= _handlers.OnChangeRole;

            _handlers = null;
            
            base.OnDisabled();
        }
    }
}
