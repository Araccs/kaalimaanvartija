using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class CanvasLoader : MonoBehaviour
    {
        public GameObject canvas;
        public GameObject canvas2;
        private GameObject buttonSounds;
        private ButtonSoundPlayer bsp;
        // Start is called before the first frame update
        public void LoadCanvas ()
        {
            Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
            canvas.SetActive(true);
        }

        public void DestroyCanvas()
        {
            canvas.SetActive(false);
            buttonSounds = GameObject.Find("ButtonSounds");
            bsp = buttonSounds.GetComponent<ButtonSoundPlayer>();
            bsp.OnClick(2);
            Time.timeScale = 1f;
            Destroy(canvas);
        }

        public void LoadCanvas2()
        {
            Instantiate(canvas2, new Vector3(0, 0, 0), Quaternion.identity);
            canvas2.SetActive(true);
        }

        public void DestroyCanvas2()
        {
            canvas2.SetActive(false);
            buttonSounds = GameObject.Find("ButtonSounds");
            bsp = buttonSounds.GetComponent<ButtonSoundPlayer>();
            bsp.OnClick(2);
            Time.timeScale = 1f;
            Destroy(canvas2);
        }



    }
}
