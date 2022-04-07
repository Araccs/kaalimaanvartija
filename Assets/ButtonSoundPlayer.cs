using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class ButtonSoundPlayer : MonoBehaviour
    {
        AudioSource audioSource;
        public float volume;
        // Start is called before the first frame update
        void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void OnClick()
        {
            audioSource.PlayOneShot(audioSource.clip,volume);
        }
    }
}
