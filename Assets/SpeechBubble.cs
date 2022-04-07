using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class SpeechBubble : MonoBehaviour
    {
        public GameObject bubble1;
        public GameObject bubble2;
        public GameObject continueButton;
        private GameObject arrowButton;
        private AudioSource audioSource;
        // Start is called before the first frame update
        void Awake()
        {
            audioSource = GetComponent<AudioSource>();
            bubble2.SetActive(false);
            continueButton.SetActive(false);
            arrowButton = GameObject.Find("Arrow_Button");
        }






        public void OnClick()
        {
            // audioSource.PlayOneShot();
            bubble1.SetActive(false);
            bubble2.SetActive(true);
            continueButton.SetActive(true);
            Destroy(arrowButton);
        }


    }
}
