using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class LevelStateChecker : MonoBehaviour
    {
        public static bool level2open = false;
        public static bool level3open = false;
        public static bool level4open = false;
        public static bool level5open = false;
        public static bool level6open = false;

        public GameObject levelComplete;

        private string sceneName;
        public GameObject timer;
        private bool once = false;

        private Scene scene;

        void Awake()
        {
            scene = SceneManager.GetActiveScene();
            sceneName = scene.name;
            timer = GameObject.Find("Timer");
        }

        void Update()
        {
            if(timer.GetComponent<Timer>().levelFinished == true)
            {
                if(sceneName == "Level1")
                {
                    level2open = true;
                    if (once == false)
                    {
                    once = true;
                    Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                    }
                }


            }
        }



    


    }
}
