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
    }
}
