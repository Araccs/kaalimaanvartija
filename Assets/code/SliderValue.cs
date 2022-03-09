using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace kaalimaanvartija
{
    public class SliderValue : MonoBehaviour
    {
        [SerializeField] TMP_Text healthText;
        public Slider healthSlider;

        // Update is called once per frame
        public void Update()
        {
            healthText.text = (healthSlider.value).ToString() + (" / 100");
        }
    }
}
