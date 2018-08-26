using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using TMPro;

namespace AlternativeMainMenus
{
    class Edit_TextMeshPro_GameObject : MonoBehaviour
    {
        public void Name(string GameObjectName, string Text)
        {
            GameObject go = GameObject.Find(GameObjectName);

            if (go)
            {
                TextMeshPro t = go.GetComponent<TextMeshPro>();
                t.text = Text;

                
            }
            else
            {
                Debug.Log("[AMM] NAME | Button " + GameObjectName + " is not exisitng, name can't be editied !");
            }
        }

        public void GraphicMode(string GameObjectName, TMP_GraphicalMode_Enum Mode)
        {
            GameObject go = GameObject.Find(GameObjectName);

            if (go)
            {
                TextMeshPro t = go.GetComponent<TextMeshPro>();
                
                switch (Mode)
                {
                    case TMP_GraphicalMode_Enum.Visible:
                        t.enabled = true;
                        break;

                    case TMP_GraphicalMode_Enum.Invisible:
                        t.enabled = false;
                        break;
                }
            }
            else
            {
                Debug.Log("[AMM] GraphicMode | Button " + GameObjectName + " is not exisitng, name can't be editied !");
            }
        }

        /*public void Sprite(string GameObjectName, Sprite Sprite)
        {
            GameObject go = GameObject.Find(GameObjectName);

            if (go)
            {
                TextMeshPro t = go.GetComponent<TextMeshPro>();

                TMPro.TMP_Sprite tSprite = new TMP_Sprite();
                tSprite.sprite = Sprite;
                tSprite.pivot = Sprite.pivot;

                t.spriteAsset = tSprite;
            }
            else
            {
                Debug.Log("[AMM] Sprite | Button " + GameObjectName + " is not exisitng, name can't be editied !");
            }
        }*/
    }
}
