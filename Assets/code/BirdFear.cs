using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class BirdFear : MonoBehaviour
    {
        private Transform player;
        private float dist;
        public float howclose;
        private Vector2 birdPosition;
        
        


        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {
            
            birdPosition = transform.position;

            //dist = Vector2.Distance(birdPosition, playPosition);
            //print("Distance to other: " + dist);

            // if(dist <= howclose || dist >= howclose)
            // {
            //     Debug.Log("NYTTT");
            // }
        }
    }
}
