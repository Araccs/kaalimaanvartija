using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class HeatwaveSpawn : MonoBehaviour
    {
        public GameObject heatwave;
        private GameObject new_heatwave;
        [SerializeField] private float speed;
        private GameObject Tilemap;
        public Slider healthbar;

        void Start()
        {
            Tilemap = GameObject.FindWithTag("Tilemap");
            speed = speed / 100f;
            new_heatwave = Instantiate(heatwave, new Vector3(-15, 0, 0),Quaternion.identity);
            new_heatwave.transform.parent = Tilemap.transform;
        }

    // Update is called once per frame
        void FixedUpdate()
        {
            new_heatwave.transform.position += new Vector3(speed, 0, 0);
            if(new_heatwave.transform.position.x > 0 && new_heatwave.transform.position.x < 1)
            {
                healthbar.value -= 1;
            }
        }
    }
}
