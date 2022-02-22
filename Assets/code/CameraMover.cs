using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class CameraMover : MonoBehaviour
    {
       private int number = 2;

        void Update()
        {
            transform.position = new Vector3(Mathf.PingPong((Time.time * 0.2f), number),0,0);
        }

    }
}
