using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace kaalimaanvartija
{
    public class BirdAi : MonoBehaviour
    {
        public Transform[] points;
        public float speed;
        private Transform player;
        private float dist;
        public float howclose;
        private Vector2 birdPosition;

        private bool fear = false;

        [SerializeField]
        private float timer;

        void Start()
        {
           
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void Update()
        {
            birdPosition = transform.position;

            dist = Vector2.Distance(birdPosition, player.position);
            print("Distance to other: " + birdPosition);

            if (timer > 0)
                {
                timer -= Time.deltaTime;
                }
                    if (timer <= 1)
                    {
                        Debug.Log("joooooo");
                        if(dist <= howclose)
                        {
                        fear = true;
                        }  

                        if (fear != true) {
                
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
}