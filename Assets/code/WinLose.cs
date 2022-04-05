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

        void Update()
        {
            
            if (healtBar.value <= 0){
                LoseLevel();
            }


        }

    

        public void LoseLevel()
        {
            if (!gameEnded)
            {
                Debug.Log("you lose");
                gameEnded = true;
                PauseGame();
            }
        }

        void PauseGame() {

            Time.timeScale = 0f;
        }


    }
}
