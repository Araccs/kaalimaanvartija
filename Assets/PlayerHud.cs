using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class PlayerHud : MonoBehaviour
    {
        private GameObject hud;
        void Awake()
        {
            hud = GameObject.Find("HUD");
        }

        // Update is called once per frame
        void Update()
        {
            if (Time.timeScale == 0.0f)
            {
                hud.SetActive(false);
            }
            else
            {
                hud.SetActive(true);
            }
        }
    }
}
