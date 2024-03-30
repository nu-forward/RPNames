using Exiled.API.Extensions;
using Exiled.API.Features;
using PlayerRoles;
using Exiled.Events.EventArgs.Player;
using Random = UnityEngine.Random;

namespace RPNames.Handlers
{
    public class PlayerHandlers
    {
        private Plugin plugin;

        public PlayerHandlers(Plugin _plugin) => plugin = _plugin;
        
        public void OnChangeRole(ChangingRoleEventArgs ev)
        {
            int randnumber = Random.Range(1000, 9999);
            
            if (ev.NewRole == RoleTypeId.Tutorial)
            {
                if (plugin.Config.TutorialNick)
                {
                    ev.Player.DisplayNickname = null; 
                    return;
                }
            }
            
            if (ev.NewRole == RoleTypeId.Scp0492 && plugin.Config.ZombieNames)
            {
                ev.Player.DisplayNickname = null;
                if (plugin.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
                return;
            }
            
            if (PlayerRolesUtils.GetTeam(ev.NewRole) != Team.SCPs && plugin.Config.ClassTitles.ContainsKey(ev.NewRole))
            {
                if (plugin.Config.randomnames && ev.NewRole != RoleTypeId.ClassD && plugin.Config.DboisSetting)
                {
                    ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()}";
                    
                    if (plugin.Config.ShowRealName)
                    {
                        ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()} ({ev.Player.Nickname})";
                    }
                    
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                    
                    return;
                }
                
                if (plugin.Config.ShowRealName && ev.NewRole != RoleTypeId.ClassD && plugin.Config.ShowRealName)
                { 
                    ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.ClassTitles[ev.NewRole]} {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()} ({ev.Player.Nickname})";
                    
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                    
                    return;
                }
                
                ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.ClassTitles[ev.NewRole]} {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()}";
                   
                if (plugin.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
                
                if (PlayerRolesUtils.GetTeam(ev.NewRole) is Team.FoundationForces)
                {
                    if (ev.NewRole is RoleTypeId.FacilityGuard)
                    {
                        if (plugin.Config.DifferentNicknamesForGuard)
                        {
                            ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.GuardNames.GetRandomValue()}";
                    
                            if (plugin.Config.ShowRealName)
                            {
                                ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.GuardNames.GetRandomValue()} ({ev.Player.Nickname})";
                            }
                        }
                        else
                        {
                            ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()}";
                    
                            if (plugin.Config.ShowRealName)
                            {
                                ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()} ({ev.Player.Nickname})";
                            }
                        }
                    }
                    else
                    {
                        if (plugin.Config.DifferentNicknamesForMTF)
                        {
                            ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.MTFNames.GetRandomValue()}";
                    
                            if (plugin.Config.ShowRealName)
                            {
                                ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.MTFNames.GetRandomValue()} ({ev.Player.Nickname})";
                            }
                        }
                        else
                        {
                            ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()}";
                    
                            if (plugin.Config.ShowRealName)
                            {
                                ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.HumanFirstNames.GetRandomValue()} {plugin.Config.HumanSecondNames.GetRandomValue()} ({ev.Player.Nickname})";
                            }
                        }
                    }
                    
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                }
                
                if (ev.NewRole == RoleTypeId.ClassD && plugin.Config.DboisSetting)
                {
                    ev.Player.DisplayNickname = $"{$"{plugin.Config.ClassTitles[ev.NewRole]}"+randnumber}";
                    
                    if (plugin.Config.ShowRealName)
                    {
                        ev.Player.DisplayNickname = $"{$"{plugin.Config.ClassTitles[ev.NewRole]}"+randnumber} ({ev.Player.Nickname})";
                    }
                    
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                }
            }
            
            if (PlayerRolesUtils.GetTeam(ev.NewRole) == Team.SCPs && plugin.Config.ClassTitles.ContainsKey(ev.NewRole))
            {
                if (!plugin.Config.scpSetting)
                {
                    if (plugin.Config.ShowRealName)
                    { 
                        ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.ClassTitles[ev.NewRole]}{randnumber} ({ev.Player.Nickname})";
                               
                        if (plugin.Config.ShowNick)
                        {
                            ev.Player.ShowHint(ev.Player.DisplayNickname);
                        }
                        
                        return;
                    }
                    
                    ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.ClassTitles[ev.NewRole]}{randnumber}";
                           
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                    
                    return;
                }
                
                if (plugin.Config.ShowRealName)
                {
                    ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.ClassTitles[ev.NewRole]} ({ev.Player.Nickname})";
                    
                    if (plugin.Config.ShowNick)
                    {
                        ev.Player.ShowHint(ev.Player.DisplayNickname);
                    }
                    
                    return;
                }
                
                ev.Player.DisplayNickname = $"[{ev.Player.Id}] {plugin.Config.ClassTitles[ev.NewRole]}";
                
                if (plugin.Config.ShowNick)
                {
                    ev.Player.ShowHint(ev.Player.DisplayNickname);
                }
            }
        }
        
        public void OnDeath(DiedEventArgs ev)
        {
            if (plugin.Config.DeathReset && ev.Player != null) ev.Player.DisplayNickname = null;
        }
    }
}
