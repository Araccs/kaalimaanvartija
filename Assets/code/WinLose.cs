using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class WinLose : MonoBehaviour
    {
        private bool gameEnded;
        public Slider healtBar;
        private GameObject loseLevelCanvas;
        public GameObject LoseLevelCanvas;
        private GameObject timerObject;
        Timer timer;

        void Awake()
        {
            timerObject = GameObject.Find("Timer");
            timer = timerObject.GetComponent<Timer>();
        }

        void Update()
        {
            
            if (healtBar.value <= 0 && timer.levelFinished == false){
                LoseLevel();
            }


        }

    

        public void LoseLevel()
        {
            if (!gameEnded)
            {
                Debug.Log("you lose");
                loseLevelCanvas = Instantiate(LoseLevelCanvas, new Vector3(0, 0, 0), Quaternion.identity);
                loseLevelCanvas.SetActive(true);
                gameEnded = true;
                PauseGame();
            }
        }

        void PauseGame() {

            Time.timeScale = 0f;
        }


    }
}
