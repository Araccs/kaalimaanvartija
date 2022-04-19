using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class MainMenuConf : MonoBehaviour
    {

        void Start()
        {
            PlayerPrefs.SetFloat("MusicVol", 1);
            PlayerPrefs.SetFloat("FXVol", 1);
        }
    }
}
