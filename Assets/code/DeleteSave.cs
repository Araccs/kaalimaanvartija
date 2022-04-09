using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class DeleteSave : MonoBehaviour
    {
        public GameObject yesNo;
        private GameObject backButton;
        private GameObject sliders;
        private GameObject deleteButton;

        private GameObject buttonSounds;
        private ButtonSoundPlayer bsp;


        void Awake()
        {
            yesNo.SetActive(false);
            deleteButton = this.gameObject;

            buttonSounds = GameObject.Find("ButtonSounds");
            bsp = buttonSounds.GetComponent<ButtonSoundPlayer>();
            backButton = GameObject.Find("BackButton");
            sliders = GameObject.Find("Sliders");
        }


        public void OnClickButton(int sound)
        {
            bsp.OnClick(sound);
            deleteButton.SetActive(false);
            backButton.SetActive(false);
            sliders.SetActive(false);
            yesNo.SetActive(true);
        }

        public void OnClickNo(int sound)
        {
            bsp.OnClick(sound);
            deleteButton.SetActive(true);
            backButton.SetActive(true);
            sliders.SetActive(true);
            yesNo.SetActive(false);
        }





    }
}
