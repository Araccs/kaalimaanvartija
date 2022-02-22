using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace kaalimaanvartija
{
    public class BirdAi : MonoBehaviour
    {
        public Transform[] points;
        int current;
        public float speed;
        public bool feared = false;
        // private Vector2 startingPosition;
        void Start()
        {
            // startingPosition = transform.position;
            current = 0;
        }

        void Update()
        {
            if (feared != true) {
                
                {
                    transform.position = Vector3.MoveTowards(transform.position, points[0].position, speed * Time.deltaTime);
                }
               
            }
             else 
                {
                transform.position = Vector3.MoveTowards(transform.position, points[1].position, speed * Time.deltaTime);
                }
            
        }
    }
}