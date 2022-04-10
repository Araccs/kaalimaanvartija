using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class ButtonSceneLoader : MonoBehaviour
    {
        public void LoadSceneButton(string level)
        {
            SceneManager.LoadScene(level);
        }

        public void LoadCurrentSceneButton(string level)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }


    }
}
