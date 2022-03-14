using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class PuluAnimator : MonoBehaviour
    {

        private Animator anim;
        private bool isMoving;
        private Vector3 startingPos;
        private Vector3 currentPos;

        void Start ()
        {
            anim = gameObject.GetComponent<Animator>();
        }
        // Update is called once per frame
        void Update()
        {
            
            Debug.Log("isnotmoging");
            anim.SetBool("isMoving", false);
            anim.SetFloat("Vertical", -1);
            if (transform.position != startingPos)
            {
                anim.SetBool ("isMoving", true);
                Debug.Log("ismoging");

                if(transform.position.x > startingPos.x)
                {
                    anim.SetFloat("Vertical", 1);
                }
            
            }
            startingPos = transform.position;
        }
    }
}
