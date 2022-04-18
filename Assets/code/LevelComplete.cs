using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class LevelComplete : MonoBehaviour
    {
        [SerializeField] private GameObject canvas;
        Scene scene;

    void Awake()
    {
            scene = SceneManager.GetActiveScene();
            canvas.SetActive(true);
            StartCoroutine(Wait());
    }

    IEnumerator Wait()
        {
            yield return new WaitForSeconds(5f);

            if(scene.name == "Level5")
            {
            SceneManager.LoadScene("GameCompleteLevel");
            }

            else
            {
            SceneManager.LoadScene("Level_Menu");
            }

        }
    



    }
}
