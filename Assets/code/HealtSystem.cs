using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class HealtSystem : MonoBehaviour
    {
       
        public Slider healtBar;
        private float currentHealth;
        public Transform damagepoint;
        //private Transform pulu;
        private float dist;
        private bool takingDamage = false;
       


        [SerializeField]
        private float damagedistant;

        void Start()
        {
          
        

        
        //pulu = GameObject.FindGameObjectWithTag("Pulu").transform;
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("current health" + healtBar.value);
            dist = Vector2.Distance(transform.position, damagepoint.position);
            Debug.Log(takingDamage);


            if (dist <= damagedistant) {
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
