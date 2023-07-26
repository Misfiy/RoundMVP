using Exiled.API.Interfaces;
using Exiled.API.Enums;
using PlayerRoles;
using System.ComponentModel;
using UnityEngine;

namespace RoundMVP
{
     public sealed class Config : IConfig
     {
          public bool IsEnabled { get; set; } = true;
          public bool Debug { get; set; } = false;
          public string killsText { get; set; } = "%killer% got %kills% kills";
          public string noKillsText { get; set; } = "No one got any kills this round!";
     }
}