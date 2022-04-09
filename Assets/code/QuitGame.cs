using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class QuitGame : MonoBehaviour
    {
    
        public void OnClick()
        {
            StartCoroutine(Wait());
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.5f);
            Application.Quit();
        }



    }
}
