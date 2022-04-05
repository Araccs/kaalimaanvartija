using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class PuluFlyAudioScript : MonoBehaviour
    {
        public AudioSource puluFlySource;

        public AudioClip puluFlyAudio;

        void Start()
        {
            puluFlySource.PlayOneShot(puluFlyAudio);
        }
    }
}
