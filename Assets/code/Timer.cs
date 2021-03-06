using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] public float timeRemaining;
    [SerializeField] TMP_Text timerText;
    private float hourTime;
    private bool timerIsRunning = false;
    public bool levelFinished;
    float workingHours;
    float percentageDay;
    float timeOfDay;
    float hourCounter = 0;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timeOfDay = 8.00f;
        hourTime = timeRemaining / 8;
        
        levelFinished = false;
    }
    void Update()
    {
        timerText.text = (timeOfDay.ToString() + ".00" );
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                hourCounter += Time.deltaTime;
                if(hourCounter >= hourTime ){
                    hourCounter = 0;
                    timeOfDay++;
                }
               
            }
            else
            {
                timeOfDay++;
               
                timeRemaining = 0;
                timerIsRunning = false;
                levelFinished = true;
            }
        }
    }






}