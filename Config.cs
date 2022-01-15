
using Rocket.API;
using SDG.Unturned;
using System.Collections.Generic;

namespace BadJujuWhiteList
{
    public class Config : IRocketPluginConfiguration
    {
        public string whitelistperm;
        public int timetokick;
        public void LoadDefaults()
        {
            whitelistperm = "pass";
            timetokick = 30;
            
           
        }
    }
}