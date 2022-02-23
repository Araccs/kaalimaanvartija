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
        public bool fear;
        
        
        void Awake() 
        {
            
        }

        void Start()
        {
           fear = feared.GetComponent<BirdFear>();
            
        }

        void Update()
        {
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