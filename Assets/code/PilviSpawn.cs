using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace kaalimaanvartija
{
    public class PilviSpawn : MonoBehaviour
    {

        public GameObject pilvet;
        [SerializeField]private float speed;
        private GameObject new_pilvet;
        private float targetPos = 20f;
        [SerializeField] private int yPos;
        [SerializeField] private int xPos;
        // Start is called before thef first frame update
        void Start()
        {
            speed = speed / 100f;
            new_pilvet = Instantiate(pilvet, new Vector3(xPos, yPos, 0),Quaternion.identity);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
                new_pilvet.transform.position += new Vector3(speed,0,0);
               

                if(new_pilvet.transform.position.x > targetPos)
                {
                    Destroy(new_pilvet);
                    new_pilvet = Instantiate(pilvet, new Vector3(xPos, yPos, 0), Quaternion.identity);
                  
                }

        }
    }
}
