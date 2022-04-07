using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class CanvasLoader : MonoBehaviour
    {
        public GameObject canvas;
        // Start is called before the first frame update
        public void LoadCanvas ()
        {
            Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
            canvas.SetActive(true);
        }

        public void DestroyCanvas()
        {
            canvas.SetActive(false);
            Destroy(canvas);
        }
    }
}
