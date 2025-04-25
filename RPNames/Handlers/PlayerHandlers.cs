using PlayerRoles;
using Exiled.Events.EventArgs.Player;
using Random = UnityEngine.Random;

namespace RPNames.Handlers
{
    internal class PlayerHandlers
    {
        public void OnChangeRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole is RoleTypeId.None or RoleTypeId.Destroyed or RoleTypeId.Filmmaker || ev.Player == null) return;
            
            string name = "";

            if (Plugin.Instance.Config.ShowId)
            {
                name += $"[{ev.Player.Id}] ";
            }
            
            switch (ev.NewRole)
            {
                case RoleTypeId.Tutorial:
                    if (Plugin.Instance.Config.TutorialNick)
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]}";
                    else
                        name += ev.Player.Nickname;
                    break;
                case RoleTypeId.Scientist: 
                    name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Plugin.Instance.Config.HumanFirstNames.RandomItem()} {Plugin.Instance.Config.HumanLastNames.RandomItem()}"; 
                    break;
                case RoleTypeId.FacilityGuard:
                    if (Plugin.Instance.Config.DifferentNicknamesForGuard)
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Plugin.Instance.Config.MtfNames}";
                    else
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Plugin.Instance.Config.HumanFirstNames.RandomItem()} {Plugin.Instance.Config.HumanLastNames.RandomItem()}";
                    break;
                case RoleTypeId.ClassD:
                    if (Plugin.Instance.Config.DboisSetting)
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Random.Range(1000, 9999)}";
                    else
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Plugin.Instance.Config.HumanFirstNames.RandomItem()} {Plugin.Instance.Config.HumanLastNames.RandomItem()}";
                    break;
                
                case RoleTypeId.CustomRole:
                case RoleTypeId.Overwatch:
                case RoleTypeId.Spectator: 
                    name = ev.Player.Nickname; 
                    break;
                
                case RoleTypeId.NtfPrivate:
                case RoleTypeId.NtfSergeant:
                case RoleTypeId.NtfSpecialist:
                case RoleTypeId.NtfCaptain:
                    if (Plugin.Instance.Config.DifferentNicknamesForMtf)
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Plugin.Instance.Config.MtfNames.RandomItem()}";
                    else
                        name += $"{Plugin.Instance.Config.ClassTitles[ev.NewRole]} {Plugin.Instance.Config.HumanFirstNames.RandomItem()} {Plugin.Instance.Config.HumanLastNames.RandomItem()}";
                    break;
                
                case RoleTypeId.Flamingo:
                case RoleTypeId.Scp049:
                case RoleTypeId.Scp0492:
                case RoleTypeId.Scp079:
                case RoleTypeId.Scp096:
                case RoleTypeId.Scp106:
                case RoleTypeId.Scp939:
                case RoleTypeId.Scp173:
                    if (Plugin.Instance.Config.scpSetting)
                        name += Plugin.Instance.Config.ClassTitles[ev.NewRole];
                    else
                        name += "???";
                    break;
                
                default: name += Plugin.Instance.Config.ClassTitles[ev.NewRole]; break;
            }
            
            if (Plugin.Instance.Config.ShowRealName)
            {
                name += $" ({ev.Player.Nickname})";
            }
            
            ev.Player.DisplayNickname = name;
            
            if (Plugin.Instance.Config.ShowNick)
            {
                ev.Player.ShowHint(name);
            }
        }
    }
}
