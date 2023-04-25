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
        bool setDarknessSettings;
        int currentScene;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            currentScene = buildIndex;
        }
        public override void OnUpdate()
        {
            base.OnUpdate();

            if(currentScene == 1)
            {
                if (!setDarknessSettings)
                {
                    if (!PatchQuest.Views.MainMenu.Instance.IsOpen)
                    {
                        Color darknessColor = new Color(0, 0, 0);
                        Darkness.Color = darknessColor;
                        Darkness.Distortion = 1;
                        Darkness.Alpha = 1;
                        Darkness.Intensity = 1;
                    }
                }
            }
        }
    }
}
