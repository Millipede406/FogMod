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
        int currentScene;

        public MelonPreferences_Category main;
        public MelonPreferences_Entry<Color> fogColor;

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();

            main = MelonPreferences.CreateCategory("Fog Mod");
            fogColor = main.CreateEntry<Color>("col", new Color(0, 0, 0), "Color");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            currentScene = buildIndex;
        }
        public override void OnUpdate()
        {
            if(currentScene == 0)
            {
                return;
            }

            Color darknessColor = fogColor.Value;
            Darkness.Color = darknessColor;
            Darkness.Distortion = 1;
            Darkness.Alpha = 1;
            Darkness.Intensity = 1;
        }
    }
}
