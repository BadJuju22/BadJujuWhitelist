using Rocket.API.Collections;
using Rocket.Core;
using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Linq;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace BadJujuWhiteList
{
    public class Plugin : RocketPlugin<Config>
    {

        public override TranslationList DefaultTranslations => new TranslationList
        {
                 { "message_kick", "Вы не находитесь в вайт листе" },
        };

        public static Plugin Instance { get; private set; }
        public string text2;
        protected override void Load()
        {
            Instance = this;

            U.Events.OnBeforePlayerConnected += Events_OnPlayerConnected;
        }

       

        private void Events_OnPlayerConnected(UnturnedPlayer uPlayer)
        {
            
          
            
            if (uPlayer.HasPermission(Configuration.Instance.whitelistperm))
            {

            }
            else
            {
                KickPlayer(uPlayer);
            }

        }
        private async Task KickPlayer(UnturnedPlayer uPlayer)
        {
            await Task.Delay(Configuration.Instance.timetokick*1000);
            if (uPlayer.HasPermission(Configuration.Instance.whitelistperm))
            {

            }
            else
            {
                uPlayer.Kick(Plugin.Instance.Translate("message_kick"));
            }
        }

        protected override void Unload()
        {

            U.Events.OnBeforePlayerConnected -= Events_OnPlayerConnected;
        }
    }
}

  

