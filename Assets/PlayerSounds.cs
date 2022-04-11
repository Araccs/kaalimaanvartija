using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace kaalimaanvartija
{
    public class PlayerSounds : MonoBehaviour
    {
        AudioSource audioSource;
        public AudioClip step1;
        public float volume;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Step()
        {
            audioSource.PlayOneShot(step1, volume);
        }
    }
}
