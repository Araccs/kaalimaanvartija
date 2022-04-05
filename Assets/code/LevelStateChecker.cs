using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class LevelStateChecker : MonoBehaviour
    {
        public static int level2open = 0;
        public static int level3open = 0;
        public static int level4open = 0;
        public static int level5open = 0;
        public static int level6open = 0;

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
                    level2open = 1;
                    if (once == false)
                    {
                    once = true;
                    Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                    SaveGame();
                    }
                }

                if (sceneName == "Level2")
                {
                    level3open = 1;
                    if (once == false)
                    {
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                    }
                }

                if (sceneName == "Level3")
                {
                    level4open = 1;
                    if (once == false)
                    {
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                    }
                }

                if (sceneName == "Level4")
                {
                    level5open = 1;
                    if (once == false)
                    {
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                    }
                }

                if (sceneName == "Level5")
                {
                    level6open = 1;
                    if (once == false)
                    {
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                    }
                }

            }
        }

        public void SaveGame() 
        {
            PlayerPrefs.SetInt("level2", level2open);
            PlayerPrefs.SetInt("level3", level3open);
            PlayerPrefs.SetInt("level4", level4open);
            PlayerPrefs.SetInt("level5", level5open);
            PlayerPrefs.SetInt("level6", level6open);
            Debug.Log("Game data saved!");
            
        }

    


    }
}