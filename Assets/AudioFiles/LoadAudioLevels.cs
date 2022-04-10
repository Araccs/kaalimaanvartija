using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace kaalimaanvartija
{
    public class LoadAudioLevels : MonoBehaviour
    {
        public AudioMixer Mixer;
        private float musicVol;
        private float FxVol;
        // Start is called before the first frame update
        void Start()
        {
            musicVol = PlayerPrefs.GetFloat("MusicVol");
            FxVol = PlayerPrefs.GetFloat("FXVol");
            Mixer.SetFloat("MusicVolume", Mathf.Log10(musicVol) * 20);
            Mixer.SetFloat("FXVolume", Mathf.Log10(FxVol) * 20);
        }

    }
}
