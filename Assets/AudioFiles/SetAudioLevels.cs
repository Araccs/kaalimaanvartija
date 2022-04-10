using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class SetAudioLevels : MonoBehaviour
    {
        public AudioMixer Mixer;

        public Slider musicSlider;
        public Slider FxSlider;

        void Awake()
        {
            musicSlider.value = PlayerPrefs.GetFloat("MusicVol");
            FxSlider.value = PlayerPrefs.GetFloat("FXVol");
        }


        public void SetMusicVolume(float soundLevel)
        {  
            Mixer.SetFloat("MusicVolume", Mathf.Log10(soundLevel) * 20);
            PlayerPrefs.SetFloat("MusicVol", musicSlider.value);
  

        }

        public void SetFXVolume(float soundLevel)
        {
            Mixer.SetFloat("FXVolume", Mathf.Log10(soundLevel) * 20);
            PlayerPrefs.SetFloat("FXVol", FxSlider.value);

        }
    }
}
