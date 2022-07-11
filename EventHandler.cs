using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace WhoContained106
{

    internal sealed class EventHandlers
    {
        private static readonly Config config = WhoContained106.Singleton.Config;
        public string playername;
        public RoleType playerrole;
        public void OnRoundEnded(RoundEndedEventArgs _)
        {
            playername = null;
            playerrole = RoleType.None;
        }
        public void OnDying(DyingEventArgs ev)
        {
            if(ev.Handler.Type == Exiled.API.Enums.DamageType.FemurBreaker)
            {
                playername = ev.Target.Nickname;
                playerrole = ev.Target.Role.Type;
            }
        }
        public void Containing(ContainingEventArgs _)
        {
            Map.Broadcast(new Exiled.API.Features.Broadcast(config.Message.Replace("{Player}", playername).Replace("{Role}", playerrole.ToString()), config.MessageDurationInSeconds, true), true);
        }
    }
}