//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    //initialize variables
    public float timeLeft = 300;
    public float timeMinutes;
    public float timeSeconds;
    
    //this function is called once per frame update
    //this function updates the time left in the game
    public void Update()
    {
        timeLeft -= Time.deltaTime;
        timeMinutes = Mathf.Floor(timeLeft / 60);
        timeSeconds = timeLeft - (timeMinutes * 60);
        timeSeconds = Mathf.Round(timeSeconds);

        GetComponent<UnityEngine.UI.Text>().text = timeMinutes + ":" + timeSeconds;

        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("ResultsScene");
        }
    }
}