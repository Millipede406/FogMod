using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatchQuest;
using MelonLoader;
using UnityEngine;

namespace FogMod
{
    public class ModMain : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);

            if(buildIndex == 1)
            {
                LoggerInstance.Msg($"Loaded main scene({sceneName}), setting darkness settings");
                SetDarknessSettings();
            }
        }

        public void SetDarknessSettings()
        {
            DarknessSettings.Light = new DarknessSettings(new Color(0, 0, 0), 1, 0);
        }
    }
}
