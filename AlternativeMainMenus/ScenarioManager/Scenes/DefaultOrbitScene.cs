using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AlternativeMainMenus.ScenarioManager.Scenes
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    class DefaultOrbitScene : Scene
    {
        public DeleteOldObjects DeleteScript { get; set; }
        GameObject scene;
        
        protected override void CreateGameObjects()
        {
            if(DeleteScript == null)
            {
                Debug.LogError("[AMM] DEFAULT ORBIT SCENE: DELETE SCRIPT IS NULL!");
            }

            else
            {
                scene = DeleteScript.baseOrbitScene;
                if (scene == null)
                {
                    Debug.LogError("[AMM] DEFAULT ORBIT SCENE: DEFAULT ORBIT SCENE GO IS NULL!");
                }

                else
                {
                    scene.SetActive(true);
                    Debug.LogError("[AMM] BASE ORBIT SCENE: " + scene.name);
                }
            }
        }
    }
}
