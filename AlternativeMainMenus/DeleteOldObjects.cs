using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace AlternativeMainMenus
{
    class DeleteOldObjects
    {
        List<string> GameObjectsToDelete { get; set; }
        public GameObject[] allObjects { get; set; }
        public GameObject baseOrbitScene { get; set; }
        public GameObject kerbalOrbitScene { get; set; }

        public void Awake()
        {
            Debug.Log("[AMM] DLTE - AWAKE !");

            GameObjectsToDelete = new List<string>();
            LoadDefaultList();
            SaveDefaultOrbitScene();
            SaveKerbalOrbitScene();


            
            DeleteObjects(); 
        }

        void RemoveMH()
        {
            if((GameObjectsToDelete.Contains("BuyMakingHistory")) && (GameObject.Find("BuyMakingHistory") == true))
            {
                 
                GameObject.Find("BuyMakingHistory").SetActive(false);
            }
        }

        void RemoveOrbitScene()
        {
            if ((GameObjectsToDelete.Contains("OrbitScene")) && (GameObject.Find("OrbitScene") == true))
            {
                GameObject.Find("OrbitScene").SetActive(false);
            }
        }

        void SaveDefaultOrbitScene()
        {
            if (GameObject.Find("OrbitScene") == true)
            {
                baseOrbitScene = GameObject.Instantiate(GameObject.Find("OrbitScene"));
                baseOrbitScene.SetActive(false);
            }
        }

        void SaveKerbalOrbitScene()
        {
            if (GameObject.Find("model01") == true)
            {
                kerbalOrbitScene = GameObject.Instantiate(GameObject.Find("model01"));
                kerbalOrbitScene.SetActive(false);
            }
        }

        public void DeleteObjects()
        {
            foreach (string o in GameObjectsToDelete)
            {
                if (GameObject.Find(o) != null)
                {
                    GameObject go = GameObject.Find(o);
                    go.SetActive(false);
                }

                //Making History Button is created after the scene, so i've to delete it later.
                Time.WaitSecond(1, RemoveMH);

                //The Orbit Scene (Kerbin + Mun + Kerbals) is created after the scene.
                Time.WaitSecond(1, RemoveOrbitScene);
            }
        }

        public void LoadDefaultList()
        {
            if (GameObjectsToDelete == null)
            {
                GameObjectsToDelete = new List<string>();
            }

            string[] gos = new string[]
            {
                "OrbitScene", //<-- All the scene with the kerbals, planet, moon in orbit. [NOT WORKING]

                //=====Kerbals=====//
                //"model01", //<-- Kerbal Male (x3)
                //"kbFemale@jp_suspended", //<-- Kerbal Female
                //"Kerbals", //<-- All the Kerbals

                //=====Galaxy=====//
                //"MainMenuGalaxy"  //<-- SkyBox Texture (I think)
                "GalaxyCube", //<-- Skybox material (I think)
                //"SkySphere Cam", //<-- Camera following the skybox

                //=====Bottom-Right Texts=====//
                //"TextCopyright", //<-- Squad / Take 2 Copyright text
                //"TextVersionNumber", //<-- Text Version Number win the Player

                //=====Main Menu Buttons=====//
                //"Text", //<-- Loading Text

                //"MainMenu", //<-- All the menu (Logo + Buttons)
                //"logo", //<-- Kerbal Space Program Logo

                //"Start Game", //<-- Start Game Button
                //"Settings", //<-- Settings Button
                //"Community", //<-- Community Button
                //"Addons", //<-- Addons & Mods Button
                //"Credits", //<-- Credits Button
                //"Quit", //<-- Quit Button

                //=====Start Game Menu=====//
                //"Header", //<-- Continue Game Text
                //"Continue Game", //<-- Continue Game Button
                //"New Game", //<-- New Game Button
                //"Scenarios", //<-- Scenarios Button
                //"Training", //<-- Training Button
                //"BuyMakingHistory", //<-- About Making History Button
                //"Back" //<-- Back Button

                //=====Landscape=====//
                //"Directional light", //<-- Light
                //"Kerbin(Clone)" //<-- Kerbin


            };

            for (int i = 0; i < gos.Length; i++)
            {
                GameObjectsToDelete.Add(gos[i]);
            }
        }
        public void AddAGameObject(string Name)
        {
            if(GameObjectsToDelete == null)
            {
                GameObjectsToDelete = new List<string>();
            }

            GameObjectsToDelete.Add(Name);
        }
    }
}
