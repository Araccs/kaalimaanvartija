using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{

    public class CameraMover : MonoBehaviour
    {
       private int number = 4;
       [SerializeField] private float speed = 1.0f;

        void Update()
        {
            transform.position = new Vector3(Mathf.PingPong((Time.time * speed), number),0,0);
        }

    }
}
