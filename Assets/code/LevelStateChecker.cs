using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class LevelStateChecker : MonoBehaviour
    {
        public Loadgame loadGame;


        public static int level2open = Loadgame.l2;
        public static int level3open = Loadgame.l3;
        public static int level4open = Loadgame.l4;
        public static int level5open = Loadgame.l5;

        public GameObject levelComplete;

        private string sceneName;
        public GameObject timer;
        private bool once = false;
        private bool gameComplete = false;

        private Scene scene;

        // void Start()
        // {
        //     loadGame();
        // }


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
                        SaveGame();
                    }
                }

                if (sceneName == "Level3")
                {
                    level4open = 1;
                    if (once == false)
                    {
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                        SaveGame();
                    }
                }

                if (sceneName == "Level4")
                {
                    level5open = 1;
                    if (once == false)
                    {
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                        SaveGame();
                    }
                }

                if (sceneName == "Level5")
                {
                    if (once == false)
                    {
                        gameComplete = true;
                        once = true;
                        Instantiate(levelComplete, new Vector3(0, 0, 0), Quaternion.identity);
                        SaveGame();
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
            Debug.Log("Game data saved!");
            
            
        }

        // public void resetSave() 
        // {
        //     PlayerPrefs.DeleteKey("level2")
        //     PlayerPrefs.DeleteKey("level3")
        //     PlayerPrefs.DeleteKey("level4")
        //     PlayerPrefs.DeleteKey("level5")
        //     Debug.Log("Game data reseted!");

        //     level2open = 0;
        //     level3open = 0;
        //     level4open = 0;
        //     level5open = 0;
        // }

       

    


    }
}
