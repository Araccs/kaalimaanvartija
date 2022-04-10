using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class Loadgame : MonoBehaviour
    {
        public static int l2;
        public static int l3;
        public static int l4;
        public static int l5;
        public static int l6;
       
       
       
       
        void Start()
        {




            l2 = PlayerPrefs.GetInt("level2");
            l3 = PlayerPrefs.GetInt("level3");
            l4 = PlayerPrefs.GetInt("level4");
            l5 = PlayerPrefs.GetInt("level5");
            l6 = PlayerPrefs.GetInt("level6");
            Debug.Log("Game data loaded!");
            Debug.Log(l2);
            Debug.Log(l3);
            Debug.Log(l4);
            Debug.Log(l5);
            Debug.Log(l6);
        
        }

    }
}
