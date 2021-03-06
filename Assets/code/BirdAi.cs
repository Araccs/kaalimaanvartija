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
        private bool reRun = false;
        private bool fear = false;
        private int life;
        [SerializeField]
        private float timer;
        AudioSource puluAudioSource;
        public AudioClip puluFearAudio;
        public AudioClip puluDamageAudio;
        public bool puluFearPlayed = false;
        [SerializeField]
        int puludmg = 1;
        
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;

            puluAudioSource = GetComponent<AudioSource>();
            puluAudioSource.enabled = true;
            
            
            
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
                            if (!puluFearPlayed)
                            {
                                puluAudioSource.PlayOneShot(puluFearAudio);
                                puluFearPlayed = true;
                            }
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

            if (transform.position == points[1].position && reRun == false) {
                StartCoroutine(restartCoroutine());
            }


        }

        IEnumerator waitCoroutine() {
            takingDamage = true;
            yield return new WaitForSeconds(2);
            TakeDamage(puludmg);
            takingDamage = false;
            
        }

        IEnumerator restartCoroutine() {
            reRun = true;
            yield return new WaitForSeconds(Random.Range(5, 30));
            fear = false;
            reRun = false;
        }


        void TakeDamage(int damage) 
        {
            
            healtBar.value -= damage;
            puluAudioSource.PlayOneShot(puluDamageAudio);

        }

        void OnTriggerEnter2D(Collider2D collision) 
        {
            if (collision.gameObject.tag == "Scarecrow")
            {
                fear = true;
                puluAudioSource.PlayOneShot(puluFearAudio);
            }
        }

        
    }
}