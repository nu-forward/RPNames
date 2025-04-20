using System;
using RPNames.Handlers;
using Exiled.Events.Handlers;

namespace RPNames
{
    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name => "Rp Names";
        public override string Prefix => "rp_names";
        public override string Author => "wexelsdev, Original plugin by: Babyboucher20 Maintained by Enes Batur";

        public override Version Version { get; } = new(4, 1, 0);
        public override Version RequiredExiledVersion { get; } = new(9, 5, 0);

        public static Plugin Instance;
        
        private PlayerHandlers _handlers;
        
        public override void OnEnabled()
        {
            Instance = this;
            _handlers = new();

            Player.ChangingRole += _handlers.OnChangeRole;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.ChangingRole -= _handlers.OnChangeRole;

            _handlers = null;
            Instance = null;
            
            base.OnDisabled();
        }
    }
}
