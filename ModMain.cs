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
            base.OnUpdate();

            if(currentScene == 1)
            {
                if (!setDarknessSettings)
                {
                    if (!PatchQuest.Views.MainMenu.Instance.IsOpen)
                    {
                        Color darknessColor = new Color(0, 0, 0);
                        DarknessSettings settings = new DarknessSettings(darknessColor, 1, 1);
                        DarknessSettings.Light = settings;
                    }
                }
            }
        }
    }
}
