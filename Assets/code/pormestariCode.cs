using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class pormestariCode : MonoBehaviour
    {
        private GameObject canvas;
        private GameObject HUD;

        void Awake()
        {
            Time.timeScale = 0.0f;
            canvas = GameObject.Find("PormestariCanvas");
            HUD = GameObject.Find("HUD");
            canvas.SetActive(true);
        }

        public void continueButton()
        {
            Time.timeScale = 1.0f;
            canvas.SetActive(false);
            HUD.SetActive(true);
            Destroy(canvas);
            Destroy(gameObject);
        }
    }
}
