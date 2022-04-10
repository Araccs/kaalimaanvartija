using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class SceneLoader : MonoBehaviour
    {
        private GameObject buttonSounds;
        private ButtonSoundPlayer bsp;
        private float duration;
        public int sound;
        

        public void loadScene (string level) {
            
            buttonSounds = GameObject.Find("ButtonSounds");
            bsp = buttonSounds.GetComponent<ButtonSoundPlayer>();
            duration = bsp.button_1.length / 2;
            bsp.OnClick(sound);
            StartCoroutine(Wait(level));

        }

        IEnumerator Wait (string level)
        {
            yield return new WaitForSeconds(duration);
            SceneManager.LoadScene(level);
        }


    }
}
