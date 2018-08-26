using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AlternativeMainMenus.ScenarioManager
{
    class SceneManager : MonoBehaviour
    {
        public DeleteOldObjects DeleteScript { get; set; }

        public GameObject CurrentScene;

        public void LoadScene(ScenesEnum Scene)
        {
            Debug.Log("[AMM] SceneManager - LOADING A SCENE");
            switch (Scene)
            {
                case ScenesEnum.DefaultOrbitScene:
                    Scenes.DefaultOrbitScene dos = new Scenes.DefaultOrbitScene();
                    dos.DeleteScript = DeleteScript;
                    dos.Load();
                    CurrentScene = dos.DeleteScript.baseOrbitScene;
                    Debug.Log("[AMM] DEFAULT ORBIT SCENE LOADED");
                    break;

                case ScenesEnum.JoolLaythe:
                    Scenes.JoolLaytheScene jls = new Scenes.JoolLaytheScene();
                    jls.Load();
                    CurrentScene = jls.SceneGO;
                    Debug.Log("[AMM] JOOl - LAYTHE SCENE LOADED");
                    break;

                case ScenesEnum.VesselDuna:
                    Scenes.VesselDunaScene vd = new Scenes.VesselDunaScene();
                    vd.DeleteScript = DeleteScript;
                    vd.Load();
                    CurrentScene = vd.SceneGO;
                    Debug.Log("[AMM] VESSEL DUNA SCENE LOADED");
                    break;
                /*default:
                    dos = new Scenes.DefaultOrbitScene();
                    dos.Load();
                    Debug.Log("[AMM] DEFAULT ORBIT SCENE LOADED");
                    break;*/
            }
        }
        public void SwitchScene(ScenesEnum Scene)
        {
            CurrentScene.SetActive(false);
            LoadScene(Scene);
        }
    }
}
