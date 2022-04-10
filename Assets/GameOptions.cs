using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class GameOptions : MonoBehaviour
    {
        private GameObject hud;
        void Awake()
        {
            hud = GameObject.Find("HUD");
            hud.SetActive(false);
        }

    }
}
