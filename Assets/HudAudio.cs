using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class HudAudio : MonoBehaviour
    {

        AudioSource audioSource;
        public float volume;
        public AudioClip button_1;
        public AudioClip button_2;
        public AudioClip button_3;
        AudioClip audioClip;
        // Start is called before the first frame update
        void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        public void OnClick(int buttonSound)
        {
            if (buttonSound == 1)
            {
                audioSource.PlayOneShot(button_1, volume);
            }

            if (buttonSound == 2)
            {
                audioSource.PlayOneShot(button_2, volume);
            }

            if (buttonSound == 3)
            {
                audioSource.PlayOneShot(button_3, volume);
            }
        }
    }
}
