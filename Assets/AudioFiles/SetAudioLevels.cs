using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace kaalimaanvartija
{
    public class SetAudioLevels : MonoBehaviour
    {
        public AudioMixer Mixer;
        public static float musicVol;
        public static float FXVol;


        public void SetMusicVolume(float soundLevel)
        {
            Mixer.SetFloat("MusicVolume", Mathf.Log10(soundLevel) * 20);
        }

        public void SetFXVolume(float soundLevel)
        {
            Mixer.SetFloat("FXVolume", Mathf.Log10(soundLevel) * 20);
        }

    }
}
