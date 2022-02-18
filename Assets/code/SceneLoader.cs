using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class SceneLoader : MonoBehaviour
    {
        public void loadScene (string GRAFFAtest) {
            SceneManager.LoadScene(GRAFFAtest);
        }
    }
}
