using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class Spawner : MonoBehaviour
    {
        
        [SerializeField]
        private float spawntime;
        
        [SerializeField]
        private GameObject prefab;

        private float timer;

        void Start()
        {
            timer = spawntime;
        }

        
        void Update()
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;

                if (timer <= 0) 
                {
                    Spawn();
                }
            }
        }

        private void Spawn()
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }

}
