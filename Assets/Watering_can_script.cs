using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace kaalimaanvartija
{
    public class Watering_can_script : MonoBehaviour
    {
        private Button wateringCanButton;
        public Slider healthslider;
        private bool used;
        private GameObject vegetable;
        [SerializeField] private int time;
        [SerializeField] private int healthBoost;
        private float dist = 1f;
        private Vector2 distance;
        private GameObject player;
        public Transform[] waterPoints = new Transform[4];
        private Transform activeWaterPoint;
        private bool isSpawned;
        public GameObject waterObject;
        private GameObject newWaterObject;

        private GameObject playerHud;
        private HudAudio hudAudio;


        void Awake()
        {
            activeWaterPoint = waterPoints[Random.Range(0, 4)];
            newWaterObject = Instantiate(waterObject, activeWaterPoint.position, Quaternion.identity);
        }

        public void OnClick()
        {
            wateringCanButton = GameObject.FindGameObjectWithTag("WateringCan").GetComponent<Button>();
            vegetable = GameObject.FindGameObjectWithTag("Vegetable");
            player = GameObject.FindGameObjectWithTag("Player");
            Debug.Log(Vector2.Distance(player.transform.position, activeWaterPoint.transform.position));


            if (used == false && Vector2.Distance(player.transform.position, activeWaterPoint.transform.position) <= dist)
            {

                healthslider.value += healthBoost;
                used = true;

                playerHud = GameObject.Find("PlayerHUD");
                hudAudio = playerHud.GetComponent<HudAudio>();
                hudAudio.OnClick(1);


                wateringCanButton.interactable = false;
                Destroy(newWaterObject);
                StartCoroutine(WaterCanTimer());
            }


        }

        IEnumerator WaterCanTimer()
        {

            yield return new WaitForSeconds(time);
            activeWaterPoint = waterPoints[Random.Range(0, waterPoints.Length-1)];
            newWaterObject = Instantiate(waterObject, activeWaterPoint.position, Quaternion.identity);
            used = false;
            wateringCanButton.interactable = true;

        }





    }
}
