using MEC;

namespace RPNames.EventHandlers
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;
    using PlayerRoles;
    using System;
    using Hints;
    using System.Collections.Generic;
    using Exiled.Events.EventArgs.Player;

    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        Random random = new Random();

        public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            if (ev.Player == null) return;
            
            int randnumber = random.Next(1000, 9999);
            
            int RandomNameNumber = random.Next(1, plugin.NickNames.Count - 1);
            
            if (ev.NewRole == RoleTypeId.Tutorial || ev.NewRole == RoleTypeId.Spectator)
            {
                if (plugin.Config.TutorialNick)
                {
                    ev.Player.DisplayNickname = null;
                }
            }
            
            if (ev.NewRole.GetTeam() != Team.SCPs && plugin.Config.ClassTitles.ContainsKey(ev.NewRole))
            {
                if (plugin.Config.ShowRealName && ev.NewRole != RoleTypeId.ClassD && plugin.Config.ShowRealName)
                { 
                    ev.Player.DisplayNickname = $"{plugin.Config.ClassTitles[ev.NewRole]} {plugin.NickNames[RandomNameNumber]} ({ev.Player.Nickname})";
                    
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                    return;
                }
                ev.Player.DisplayNickname = $"{plugin.Config.ClassTitles[ev.NewRole]} {plugin.NickNames[RandomNameNumber]}";
                
                if (plugin.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
                
                if (ev.NewRole == RoleTypeId.ClassD && plugin.Config.DboisSetting)
                {
                        ev.Player.DisplayNickname = $"{"D-"+randnumber}";

                        if (plugin.Config.ShowRealName)
                        {
                            ev.Player.DisplayNickname = $"{"D-"+randnumber} ({ev.Player.Nickname})";
                        }
                        if (plugin.Config.ShowNick)
                        {
                            ev.Player.ShowHint(ev.Player.DisplayNickname);
                        }
                }
            }
            
            if (ev.NewRole.GetTeam() == Team.SCPs && plugin.Config.ClassTitles.ContainsKey(ev.NewRole))
            {
                if (plugin.Config.SCPSetting.Equals(false))
                {
                        if (plugin.Config.ShowRealName)
                        {
                            ev.Player.DisplayNickname = $"D-{randnumber} ({ev.Player.Nickname})";
                            return;
                        }
                        ev.Player.DisplayNickname = $"D-{randnumber}";
                        return;
                }
                
                if (plugin.Config.ShowRealName)
                {
                    ev.Player.DisplayNickname = $"{plugin.Config.ClassTitles[ev.NewRole]} ({ev.Player.Nickname})";
                    return;
                }
                ev.Player.DisplayNickname = $"{plugin.Config.ClassTitles[ev.NewRole]}";
            }
            
            if (plugin.Config.ShowNick)
            {
                ev.Player.ShowHint(ev.Player.DisplayNickname);
            }
        }

        public void OnPlayerDeath(DiedEventArgs ev)
        {
            if (plugin.Config.DeathReset && ev.Player != null) ev.Player.DisplayNickname = null;
        }
    }
}

