using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class hudScript : MonoBehaviour
    {
        public GameObject hud;
        // Start is called before the first frame update
        void Start()
        {
            hud = GameObject.Find("HUD");
            hud.SetActive(true);
        }

    }
}
