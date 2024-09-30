//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCollisionWithBall : MonoBehaviour
{
    //initialize variables
    public string ComputerState;
    
    //this function switches possession of the ball when the computer steals it and resets variables that correspond to the old possessions
    public void OnCollisionEnter()
    {
        ComputerState = GetString("ComputerState");

        if (ComputerState == "Defense")
        {
            PlayerPrefs.SetString("PlayerState", "Defense");
            PlayerPrefs.SetString("ComputerState", "Offense");
            SetString("Block", "");
            SetString("Shoot", "");
            PlayerPrefs.SetFloat("TimeShootButtonHeldFor", 0f);
            SetString("Distance", "");
            SetString("OpponentShoot", "");
            PlayerPrefs.SetInt("InvokedTimes", 0);
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
