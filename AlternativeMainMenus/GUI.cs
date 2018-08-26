using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace AlternativeMainMenus
{
    //[KSPAddon(KSPAddon.Startup.MainMenu, false)]
    class GUI : MonoBehaviour
    {
        GameObject[] allObjects;

        Vector2 windowSize;

        Vector2 scrollPosition;

        string objectToFind;

        bool t = true;

        bool enable = false;

        bool oneTime = true;
        public GameObject CoreGO;

        float posX = 0;
        float posY = 0;

        public DeleteOldObjects DeleteScript { get; set; }

        public void Awake()
        {
            Debug.Log("[AMM] GUI - AWAKE !");

            objectToFind = "Type for GameObject (Exact name)";

            windowSize.x = 450;
            windowSize.y = 600;

            scrollPosition = new Vector2(0, 0);

        }

        public void OnGUI()
        {
            /*GUILayout.BeginVertical("GameObject list in the scene", new GUIStyle(UnityEngine.GUI.skin.window), GUILayout.Height(windowSize.y), GUILayout.Width(windowSize.x));
            GUILayout.BeginVertical("Type to search a GameObject", new GUIStyle(UnityEngine.GUI.skin.window), GUILayout.Height(30), GUILayout.Width(windowSize.x));
            objectToFind = GUILayout.TextArea(objectToFind);

            if (allObjects != null)
            {
                for (int i = 0; i < allObjects.Length; i++)
                {
                    if (allObjects[i].name == objectToFind)
                    {
                        allObjects[i].SetActive(GUILayout.Toggle(t, allObjects[i].name));
                    }
                }
            }*/

            if (CoreGO != null)
            {
                GUILayout.BeginVertical();
                GUILayout.Label("Active scene: " + CoreGO.GetComponent<ScenarioManager.SceneManager>().CurrentScene);
                if (GUILayout.Button("Switch to OrbitScene (default)")) CoreGO.GetComponent<ScenarioManager.SceneManager>().SwitchScene(ScenarioManager.ScenesEnum.DefaultOrbitScene);
                if (GUILayout.Button("Switch to JoolLaytheScene")) CoreGO.GetComponent<ScenarioManager.SceneManager>().SwitchScene(ScenarioManager.ScenesEnum.JoolLaythe);
                if (GUILayout.Button("Switch to VesselDunaScene")) CoreGO.GetComponent<ScenarioManager.SceneManager>().SwitchScene(ScenarioManager.ScenesEnum.VesselDuna);
                GUILayout.EndVertical();

                /*if(GameObject.Find("logo"))
                {
                    GUILayout.Label("PosX = " + posX + "F");
                    posX = GUILayout.HorizontalSlider(posX, -2f, 2f);

                    GUILayout.Label("PosY = " + posY + "F");
                    posY = GUILayout.HorizontalSlider(posY, -2f, 2f);
                }*/

                /*GameObject startGO = GameObject.Find("Start Game");

                MonoBehaviour[] scriptComponents = startGO.GetComponents<MonoBehaviour>();

                foreach (MonoBehaviour script in scriptComponents)
                {
                    script.enabled = GUILayout.Toggle(script.enabled, script.ToString());
                }*/
            }


            /*GUILayout.Label("Camera Pos = " + Camera.main.transform.position);
            lockCam = GUILayout.Toggle(lockCam, "Lock Camera");
            GUILayout.Label("CamPosX = " + camPosX);
            camPosX = GUILayout.HorizontalSlider(camPosX, -50.0F, 50.0F);
            GUILayout.Label("CamPosY = " + camPosY);
            camPosY = GUILayout.HorizontalSlider(camPosY, -50.0F, 50.0F);
            GUILayout.Label("CamPosZ = " + camPosZ);
            camPosZ = GUILayout.HorizontalSlider(camPosZ, -50.0F, 50.0F);

            GUILayout.Label("LightRotX = " + lightRotX);
            lightRotX = GUILayout.HorizontalSlider(lightRotX, 0.0F, 360.0F);
            GUILayout.Label("LightRotY = " + lightRotY);
            lightRotY = GUILayout.HorizontalSlider(lightRotY, 0.0F, 360.0F);
            GUILayout.Label("LightRotZ = " + lightRotZ);
            lightRotZ = GUILayout.HorizontalSlider(lightRotZ, 0.0F, 360.0F);*/

            //GUILayout.EndVertical();

            //UpdateObjects();

            //scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Height(windowSize.y));
            //if (allObjects != null)
            //{
            //    for (int i = 0; i < allObjects.Length; i++)
            //    {
            //        allObjects[i].SetActive(GUILayout.Toggle(t, allObjects[i].name));
            //    }
            //}
            //GUILayout.EndScrollView();
            //GUILayout.EndVertical();
            //}
        }
        //void UpdateObjects()
        //{
        //    allObjects = FindObjectsOfType<GameObject>();
        //}
        /*void Update()
        {
            GameObject g = GameObject.Find("logo");
            g.transform.position = new Vector3(posX, posY, g.transform.position.z);
        }*/
    }
}