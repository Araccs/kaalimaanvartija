using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class PauseGame : MonoBehaviour
    {
        // Start is called before the first frame update
        public void pauseGame()
        {
            Time.timeScale = 0f;
        }

        // Update is called once per frame
        public void continueGame()
        {
            Time.timeScale = 1f;
        }
    }
}
