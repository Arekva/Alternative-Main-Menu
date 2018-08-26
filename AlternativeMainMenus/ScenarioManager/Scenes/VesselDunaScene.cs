using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

//using UnityEngineInternal;

namespace AlternativeMainMenus.ScenarioManager.Scenes
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    class VesselDunaScene : Scene
    {
        public DeleteOldObjects DeleteScript { get; set; }

        protected override void CreateGameObjects()
        {
            SceneGO = new GameObject("VesselDunaScene");

            LandScape();

            UI();
            
        }

        protected override void Update()
        {
            //Fix Duna's Rotation in the VesselDunaScene
            GameObject Duna = GameObject.Find("DunaSC");

            float DunaRotationSpeed = -0.5f;

            if (Duna != null)
            {
                Duna.transform.Rotate(new Vector3(0, DunaRotationSpeed, 0) * UnityEngine.Time.deltaTime);
            }

            GameObject Ike = GameObject.Find("IkeSC");

            float IkeOrbitSpeed = -1f;

            if (Ike != null)
            {
                Ike.transform.RotateAround(Duna.transform.position, Vector3.up, IkeOrbitSpeed * UnityEngine.Time.deltaTime);
            }
        }

        void UI()
        {
            GameObject UI = new GameObject("UI");
            UI.transform.parent = SceneGO.transform;
            RectTransform rt;
            float size = 2048;
            Color color = new Color(0.87f, 0.87f, 0.87f, 0.6f);
            Edit_TextMeshPro_GameObject EditTMP = new Edit_TextMeshPro_GameObject();


            //LOGO
            GameObject logo = GameObject.Find("logo");
            logo.transform.position = new Vector3(0.727f, 0.383f, logo.transform.position.z);

            //START GAME
            GameObject StartGame = GameObject.Find("Start Game");
            StartGame.transform.parent = UI.transform;
            GameObject StartGameIcon = new GameObject("Start Game Icon");
            StartGameIcon.transform.parent = StartGame.transform;
            EditTMP.GraphicMode("Start Game", TMP_GraphicalMode_Enum.Invisible);
            Texture2D texIdleStartGame = GameDatabase.Instance.GetTexture("AlternativeMainMenu/MenuData/VesselDuna/startgameicon", false);
            Sprite sIdleStartGame = Sprite.Create(texIdleStartGame, new Rect(0f, 0f, texIdleStartGame.width, texIdleStartGame.height), new Vector2(0.5f, 0.5f), size);
            SpriteRenderer srStartGame = StartGameIcon.AddComponent<SpriteRenderer>();
            srStartGame.sprite = sIdleStartGame;
            srStartGame.color = color;
            rt = StartGame.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0.32f, 0.32f, rt.localPosition.z);
            StartGameIcon.transform.position = StartGame.transform.position;


            //SETTINGS
            GameObject Settings = GameObject.Find("Settings");
            Settings.transform.parent = UI.transform;
            GameObject SettingsIcon = new GameObject("Settings Icon");
            SettingsIcon.transform.parent = Settings.transform;
            EditTMP.GraphicMode("Settings", TMP_GraphicalMode_Enum.Invisible);
            Texture2D texIdleSettings = GameDatabase.Instance.GetTexture("AlternativeMainMenu/MenuData/VesselDuna/settingsicon", false);
            Sprite sIdleSettings = Sprite.Create(texIdleSettings, new Rect(0f, 0f, texIdleSettings.width, texIdleSettings.height), new Vector2(0.5f, 0.5f), size);
            SpriteRenderer srSettings = SettingsIcon.AddComponent<SpriteRenderer>();
            srSettings.sprite = sIdleSettings;
            srSettings.color = color;
            rt = Settings.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0.392f, 0.191f, rt.localPosition.z);
            SettingsIcon.transform.position = Settings.transform.position;


            //COMMUNITY
            GameObject Community = GameObject.Find("Community");
            Community.transform.parent = UI.transform;
            GameObject CommunityIcon = new GameObject("Community Icon");
            CommunityIcon.transform.parent = Community.transform;
            EditTMP.GraphicMode("Community", TMP_GraphicalMode_Enum.Invisible);
            Texture2D texIdleCommunity = GameDatabase.Instance.GetTexture("AlternativeMainMenu/MenuData/VesselDuna/communityicon", false);
            Sprite sIdleCommunity = Sprite.Create(texIdleCommunity, new Rect(0f, 0f, texIdleCommunity.width, texIdleCommunity.height), new Vector2(0.5f, 0.5f), size);
            SpriteRenderer srCommunity = CommunityIcon.AddComponent<SpriteRenderer>();
            srCommunity.sprite = sIdleCommunity;
            srCommunity.color = color;
            rt = Community.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0.46f, 0.05f, rt.localPosition.z);
            CommunityIcon.transform.position = Community.transform.position;


            //ADDONS
            GameObject Addons = GameObject.Find("Addons");
            Addons.transform.parent = UI.transform;
            GameObject AddonsIcon = new GameObject("Addons Icon");
            AddonsIcon.transform.parent = Addons.transform;
            EditTMP.GraphicMode("Addons", TMP_GraphicalMode_Enum.Invisible);
            Texture2D texIdleAddons = GameDatabase.Instance.GetTexture("AlternativeMainMenu/MenuData/VesselDuna/addonsicon", false);
            Sprite sIdleAddons = Sprite.Create(texIdleAddons, new Rect(0f, 0f, texIdleAddons.width, texIdleAddons.height), new Vector2(0.5f, 0.5f), size);
            SpriteRenderer srAddons = AddonsIcon.AddComponent<SpriteRenderer>();
            srAddons.sprite = sIdleAddons;
            srAddons.color = color;
            rt = Addons.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(/*0.565f*/ 0.5f, -0.105f, rt.localPosition.z);
            AddonsIcon.transform.position = Addons.transform.position;


            //CREDITS
            GameObject Credits = GameObject.Find("Credits");
            Credits.transform.parent = UI.transform;
            GameObject CreditsIcon = new GameObject("Credits Icon");
            CreditsIcon.transform.parent = Credits.transform;
            EditTMP.GraphicMode("Credits", TMP_GraphicalMode_Enum.Invisible);
            Texture2D texIdleCredits = GameDatabase.Instance.GetTexture("AlternativeMainMenu/MenuData/VesselDuna/creditsicon", false);
            Sprite sIdleCredits = Sprite.Create(texIdleCredits, new Rect(0f, 0f, texIdleCredits.width, texIdleCredits.height), new Vector2(0.5f, 0.5f), size);
            SpriteRenderer srCredits = CreditsIcon.AddComponent<SpriteRenderer>();
            srCredits.sprite = sIdleCredits;
            srCredits.color = color;
            rt = Credits.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0.497f, -0.287f, rt.localPosition.z);
            CreditsIcon.transform.position = Credits.transform.position;


            //QUIT
            GameObject Quit = GameObject.Find("Quit");
            Quit.transform.parent = UI.transform;
            GameObject QuitIcon = new GameObject("Quit Icon");
            QuitIcon.transform.parent = Quit.transform;
            EditTMP.GraphicMode("Quit", TMP_GraphicalMode_Enum.Invisible);
            Texture2D texIdleQuit = GameDatabase.Instance.GetTexture("AlternativeMainMenu/MenuData/VesselDuna/Quiticon", false);
            Sprite sIdleQuit = Sprite.Create(texIdleQuit, new Rect(0f, 0f, texIdleQuit.width, texIdleQuit.height), new Vector2(0.5f, 0.5f), size);
            SpriteRenderer srQuit = QuitIcon.AddComponent<SpriteRenderer>();
            srQuit.sprite = sIdleQuit;
            srQuit.color = color;
            rt = Quit.GetComponent<RectTransform>();
            rt.localPosition = new Vector3(0.469f, -0.468f, rt.localPosition.z);
            QuitIcon.transform.position = Quit.transform.position;
        }

        void LandScape()
        {
            GameObject LandScape = new GameObject("LandScape");
            LandScape.transform.parent = SceneGO.transform;

            GameObject planet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            planet.name = "DunaSC";
            CelestialBody duna = PSystemManager.Instance.localBodies.Find(b => b.name == "Duna");
            planet.GetComponent<Renderer>().material = duna.scaledBody.GetComponent<Renderer>().material;
            planet.GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(6, 1);
            planet.transform.position = new Vector3(-226, -140, 750);
            planet.transform.localScale = new Vector3(500, 500, 500);
            planet.transform.rotation = Quaternion.Euler(new Vector3(-10, -6, 22));//0, 0, 35));
            planet.transform.parent = LandScape.transform;

            GameObject directionalLight = new GameObject("Directional Light (Sun)");
            directionalLight.transform.position = new Vector3(0, 0, 0);
            Light light = directionalLight.AddComponent<Light>();
            light.type = LightType.Directional;
            light.color = new Color(1, 1, 1, 1);
            directionalLight.transform.rotation = Quaternion.Euler(new Vector3(32, 235, -50));
            directionalLight.transform.parent = LandScape.transform;

            GameObject moon = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            moon.name = "IkeSC";
            CelestialBody laythe = PSystemManager.Instance.localBodies.Find(b => b.name == "Ike");
            moon.GetComponent<Renderer>().material = laythe.scaledBody.GetComponent<Renderer>().material;
            moon.GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(6, 1);
            moon.transform.position = new Vector3(600, 0, 930);
            moon.transform.localScale = new Vector3(100, 100, 100);
            moon.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 35));  
            moon.transform.parent = LandScape.transform;
        }
    }
}
