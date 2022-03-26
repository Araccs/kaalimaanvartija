using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace kaalimaanvartija
{
    public class LevelComplete : MonoBehaviour
    {
        [SerializeField] private GameObject canvas;

    void Awake()
    {
            canvas.SetActive(true);
            StartCoroutine(Wait());
    }

    IEnumerator Wait()
        {
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene("Level_Menu");
        }
    



    }
}
