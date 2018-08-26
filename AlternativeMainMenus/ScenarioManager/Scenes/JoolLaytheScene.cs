using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AlternativeMainMenus.ScenarioManager.Scenes
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    class JoolLaytheScene : Scene
    {
        GameObject planet;
        GameObject moon;

        bool enableUpdate = false;

        

        protected override void CreateGameObjects()
        {
            SceneGO = new GameObject("JoolLaytheScene");
            SceneGO.transform.position = new Vector3(0, 0, 0);

            int planetSubdivisions = 6;
            float planetRadius = 1f;

            

            planet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            CelestialBody jool = PSystemManager.Instance.localBodies.Find(b => b.name == "Jool");
            planet.GetComponent<Renderer>().material = jool.scaledBody.GetComponent<Renderer>().material;
            planet.GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(planetSubdivisions, planetRadius);
            planet.transform.position = new Vector3(400, 600, 1000);
            planet.transform.localScale = new Vector3(700, 700, 700);
            planet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 75));

            GameObject directionalLight = new GameObject();
            directionalLight.transform.position = new Vector3(0, 0, 0);
            Light light = directionalLight.AddComponent<Light>();
            light.type = LightType.Directional;
            light.color = new Color(1, 1, 1, 1);
            directionalLight.transform.rotation = Quaternion.Euler(new Vector3(216, 445, -535));

            moon = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            CelestialBody laythe = PSystemManager.Instance.localBodies.Find(b => b.name == "Laythe");
            moon.GetComponent<Renderer>().material = laythe.scaledBody.GetComponent<Renderer>().material;
            moon.GetComponent<MeshFilter>().mesh = OctahedronSphereCreator.Create(planetSubdivisions, planetRadius);
            moon.transform.position = new Vector3(-330, -140, 450);
            moon.transform.localScale = new Vector3(200, 200, 200);
            //planet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

            planet.transform.parent = SceneGO.transform;
            light.transform.parent = SceneGO.transform;
            moon.transform.parent = SceneGO.transform;
            
        }
    }
}
