using System;
using Exiled.API.Features;

namespace WhoContained106
{
    public class WhoContained106 : Plugin<Config>
    {
        public static WhoContained106 Singleton { get; private set; }
        private static string remembername;
        private static RoleType rememberrole;
        private EventHandlers Eventhandler { get; set; }
        public override void OnEnabled()
        {
            Log.Debug("¡Gracias por usar mi plugin! Cualquier bug o sugerencia notificar a: \"nombre_original#8857\"");
            Singleton = this;
            Eventhandler = new EventHandlers()
            {
                playername = remembername,
                playerrole = rememberrole
            };
            RegisterEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            UnregisterEvents();
            remembername = Eventhandler.playername;
            rememberrole = Eventhandler.playerrole;
            Eventhandler = null;
            Singleton = null;
            base.OnDisabled();
        }
        public override void OnReloaded()
        {
            base.OnReloaded();
        }
        private void RegisterEvents()
        {
            Exiled.Events.Handlers.Server.RoundStarted += Eventhandler.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundEnded += Eventhandler.OnRoundEnded;
            Exiled.Events.Handlers.Player.Dying += Eventhandler.OnDying;
            Exiled.Events.Handlers.Scp106.Containing += Eventhandler.Containing;
        }
        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= Eventhandler.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundEnded -= Eventhandler.OnRoundEnded;
            Exiled.Events.Handlers.Player.Dying -= Eventhandler.OnDying;
            Exiled.Events.Handlers.Scp106.Containing -= Eventhandler.Containing;
        }
        public override string Name => "WhoContained106";
        public override string Author => "MarcosVLl2";
        public override Version Version { get; } = new Version(1, 0, 3);
        public override Version RequiredExiledVersion { get; } = new Version(5, 3, 0);
    }
}