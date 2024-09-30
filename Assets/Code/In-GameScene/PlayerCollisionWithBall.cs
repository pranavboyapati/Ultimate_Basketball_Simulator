//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionWithBall : MonoBehaviour
{
    //initialize variables
    public string PlayerState;
    
    //this function switches the possession if the player collides with the ball and steals it
    public void OnCollisionEnter()
    {
        PlayerState = GetString("PlayerState");

        if (PlayerState == "Defense")
        {
            PlayerPrefs.SetString("PlayerState", "Offense");
            PlayerPrefs.SetString("ComputerState", "Defense");
            PlayerPrefs.SetInt("InvokedTimes", 0);
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
