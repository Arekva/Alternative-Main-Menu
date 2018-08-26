using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace AlternativeMainMenus
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class Core : MonoBehaviour
    {
        GameObject[] allObjects;

        public GameObject CoreGO;

        DeleteOldObjects dlte;

        Edit_TextMeshPro_GameObject EditTMP;
        GUI gui;

        bool t = true;

        public static GameObject planet { get; set; }
        public static GameObject directionalLight { get; set; }
        public static GameObject moon { get; set; }

        ScenarioManager.SceneManager sm;

        public void Awake()
        {
            CoreGO = new GameObject();

            dlte = new DeleteOldObjects();
            dlte.allObjects = allObjects;
            dlte.Awake();

            CoreGO.AddComponent<ScenarioManager.SceneManager>();
            CoreGO.GetComponent<ScenarioManager.SceneManager>().DeleteScript = dlte;
            CoreGO.GetComponent<ScenarioManager.SceneManager>().LoadScene(ScenarioManager.ScenesEnum.DefaultOrbitScene);

            if (CoreGO.GetComponent<ScenarioManager.SceneManager>() != null ) Debug.Log("[AMM] CORE - SM : " + CoreGO.GetComponent<ScenarioManager.SceneManager>());
            else Debug.Log("[AMM] CORE - SM IS NULL");

            CoreGO.AddComponent<GUI>();
            CoreGO.GetComponent<GUI>().CoreGO = CoreGO;
            CoreGO.GetComponent<GUI>().DeleteScript = dlte;

            UpdateObjects();
        }

        void Update()
        {
            
        }
        
        void UpdateObjects()
        {
            allObjects = FindObjectsOfType<GameObject>();
        }
    }
}