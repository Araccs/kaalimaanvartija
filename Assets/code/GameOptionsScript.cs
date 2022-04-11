using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class GameOptionsScript : MonoBehaviour
    {

        private GameObject hud;
        public GameObject canvas;

        private GameObject buttonSounds;
        private ButtonSoundPlayer bsp;

        void Start()
        {
            hud = GameObject.Find("HUD");
        }

        public void OpenOptions()
        {
            Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
            canvas.SetActive(true);
            hud.SetActive(false);
            Time.timeScale = 0f;
        }

        public void CloseOptions()
        {
            canvas.SetActive(false);
            buttonSounds = GameObject.Find("ButtonSounds");
            bsp = buttonSounds.GetComponent<ButtonSoundPlayer>();
            bsp.OnClick(2);
            Time.timeScale = 1f;
            hud.SetActive(true);
            Destroy(canvas);
        }




    }
}
