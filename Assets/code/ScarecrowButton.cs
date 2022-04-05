using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class ScarecrowButton : MonoBehaviour
    {
        private Transform player;
        public GameObject Scarecrow;
        private bool spawned;
        private GameObject newScarecrow;
        private Button ScarecrowNappi;

        [SerializeField]
        private int time;
        [SerializeField]
        private int timeodota;

        AudioSource scarecrowAudioSource;
        public AudioClip scarecrowAudioSpawn;
        public AudioClip scarecrowAudioDestroy;

        public void TaskOnClick()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            ScarecrowNappi = GameObject.FindGameObjectWithTag("ScarecrowNappi").GetComponent<Button>();
            
            if (spawned == false)
            {
                newScarecrow = Instantiate (Scarecrow, player.transform.position, Quaternion.identity);
                scarecrowAudioSource.PlayOneShot(scarecrowAudioSpawn);
                spawned = true;
                ScarecrowNappi.interactable = false;
                StartCoroutine (ScarecrowTimer());
                
            }   
        }

        IEnumerator ScarecrowTimer() 
        {
            
            yield return new WaitForSeconds(time);
            Destroy (newScarecrow);
            scarecrowAudioSource.PlayOneShot(scarecrowAudioDestroy);
            spawned = false;
            yield return new WaitForSeconds(timeodota);
            ScarecrowNappi.interactable = true;
            
        }



    }
}
