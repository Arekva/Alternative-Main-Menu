using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AlternativeMainMenus.ScenarioManager.Scenes
{
    class Scene : MonoBehaviour
    {
        public GameObject SceneGO { get; set; }

        public void Load()
        {
            CreateGameObjects();
        }

        protected virtual void CreateGameObjects()
        { 
        }

        protected virtual void Update()
        { 
        }
    }
}
