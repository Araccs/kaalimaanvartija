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
        // private Vector2 startingPosition;
        void Start()
        {
            // startingPosition = transform.position;
            current = 0;
        }

        void Update()
        {
            if (transform.position != points[current].position)
            {
                transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
            }
            else
                current = (current + 1) % points.Length;
        }
    }
}