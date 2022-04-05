using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class LevelButtonChanger : MonoBehaviour
    {
        public Sprite newImg;

        //Buttonit
        private GameObject level2;
        private GameObject level3;
        private GameObject level4;
        private GameObject level5;
        private GameObject level6;

        // Buttonien tekstikomponentit
        private GameObject level2_tmp;
        private GameObject level3_tmp;
        private GameObject level4_tmp;
        private GameObject level5_tmp;
        private GameObject level6_tmp;



        void Awake()
        {
            //assignoidaan oikeat objektit
            level2 = GameObject.Find("Level_2");
            level3 = GameObject.Find("Level_3");
            level4 = GameObject.Find("Level_4");
            level5 = GameObject.Find("Level_5");
            level6 = GameObject.Find("Level_6");

            level2_tmp = GameObject.Find("Level_2_TMP");
            level2_tmp.SetActive(false);

            level3_tmp = GameObject.Find("Level_3_TMP");
            level3_tmp.SetActive(false);

            level4_tmp = GameObject.Find("Level_4_TMP");
            level4_tmp.SetActive(false);

            level5_tmp = GameObject.Find("Level_5_TMP");
            level5_tmp.SetActive(false);

            level6_tmp = GameObject.Find("Level_6_TMP");
            level6_tmp.SetActive(false);

        }

        void Update()
        {
        //tarkistetaan onko leveli unlockattu
        if(LevelStateChecker.level2open == 1)
            {
                // jos leveli on unlockattu, vaihdetaan nappiin sprite ja aktivoidaan teksti (levelin numero).
                level2.GetComponent<Image>().sprite = newImg;
                level2.GetComponent<Button>().interactable = true;
                level2_tmp.SetActive(true);
            }
        if (LevelStateChecker.level3open == 1)
            {
                level3.GetComponent<Image>().sprite = newImg;
                level3.GetComponent<Button>().interactable = true;
                level3_tmp.SetActive(true);
            }
        if (LevelStateChecker.level4open == 1)
            {
                level4.GetComponent<Image>().sprite = newImg;
                level4.GetComponent<Button>().interactable = true;
                level3_tmp.SetActive(true);
            }
        if (LevelStateChecker.level5open == 1)
            {
                level5.GetComponent<Image>().sprite = newImg;
                level5.GetComponent<Button>().interactable = true;
                level3_tmp.SetActive(true);
            }
        if (LevelStateChecker.level6open == 1)
            {
                level6.GetComponent<Image>().sprite = newImg;
                level6.GetComponent<Button>().interactable = true;
                level3_tmp.SetActive(true);
            }
        }



    }
}
