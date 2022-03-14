using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

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
        private bool takingDamage = false;
        public Slider healtBar;

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
            

            if (timer > 0)
                {
                timer -= Time.deltaTime;
                }
                    if (timer <= 1)
                    {
                        
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

                if (transform.position == points[0].position) {
                    if (takingDamage == false) {
                     StartCoroutine(waitCoroutine());
                
                     }
                
                }




        }

        IEnumerator waitCoroutine() {
            takingDamage = true;
            yield return new WaitForSeconds(2);
            TakeDamage(1);
            takingDamage = false;
            
        }


        void TakeDamage(int damage) 
        {
            healtBar.value -= damage;


        }





    }
}