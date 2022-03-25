using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class pormestariCode : MonoBehaviour
    {
        private GameObject canvas;

        void Awake()
        {
            Time.timeScale = 0.0f;
            canvas = GameObject.Find("PormestariCanvas");
            canvas.SetActive(true);
        }

        public void continueButton()
        {
            Time.timeScale = 1.0f;
            canvas.SetActive(false);
            Destroy(canvas);
            Destroy(gameObject);
        }
    }
}
