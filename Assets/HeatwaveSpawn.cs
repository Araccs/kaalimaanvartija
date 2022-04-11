using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class HeatwaveSpawn : MonoBehaviour
    {
        public GameObject heatwave;
        public int distance;
        private GameObject new_heatwave;
        [SerializeField] private float speed;
        private GameObject Tilemap;
        public Slider healthbar;
        private bool destroyed;

        void Start()
        {
            Tilemap = GameObject.FindWithTag("Tilemap");
            speed = speed / 100f;
            new_heatwave = Instantiate(heatwave, new Vector3(-25, 0, 0),Quaternion.identity);
            new_heatwave.transform.parent = Tilemap.transform;
            destroyed = false;
        }

    // Update is called once per frame
        void FixedUpdate()
        {

            if(destroyed == false)
            {

                new_heatwave.transform.position += new Vector3(speed, 0, 0);
                if (new_heatwave.transform.position.x > 0 && new_heatwave.transform.position.x < 0.5f)
                {
                    healthbar.value -= 1;
                }
                else if (new_heatwave.transform.position.x > distance)
                {
                    Destroy(new_heatwave);
                    destroyed = true;
                    new_heatwave = Instantiate(heatwave, new Vector3(-25, 0, 0), Quaternion.identity);
                    new_heatwave.transform.parent = Tilemap.transform;
                    destroyed = false;
                }


            }
           

        }
    }
}
