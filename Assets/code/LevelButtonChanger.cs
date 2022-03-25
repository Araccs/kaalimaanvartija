using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class LevelButtonChanger : MonoBehaviour
    {
        public Sprite newImg;
        private Image level2img;
        private Image level3img;
        private Image level4img;
        private Image level5img;
        private Image level6img;

        void Awake()
        {
            level2img = GameObject.Find("Level_2").GetComponent<Image>();
            level3img = GameObject.Find("Level_3").GetComponent<Image>();
            level4img = GameObject.Find("Level_4").GetComponent<Image>();
            level5img = GameObject.Find("Level_5").GetComponent<Image>();
            level6img = GameObject.Find("Level_6").GetComponent<Image>();
        }

        // Update is called once per frame
        void Update()
        {
        if(LevelStateChecker.level2open == true)
            {
                level2img.sprite = newImg;
                GameObject.Find("Level_2").GetComponent<Button>().interactable = true;
            }
        if (LevelStateChecker.level3open == true)
            {
                level3img.sprite = newImg;
                GameObject.Find("Level_3").GetComponent<Button>().interactable = true;
            }
        if (LevelStateChecker.level4open == true)
            {
                level4img.sprite = newImg;
                GameObject.Find("Level_4").GetComponent<Button>().interactable = true;
            }
        if (LevelStateChecker.level5open == true)
            {
                level5img.sprite = newImg;
                GameObject.Find("Level_5").GetComponent<Button>().interactable = true;
            }
        if (LevelStateChecker.level6open == true)
            {
                level6img.sprite = newImg;
                GameObject.Find("Level_6").GetComponent<Button>().interactable = true;
            }
        }



    }
}
