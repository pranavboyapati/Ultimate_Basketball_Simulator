//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOutOfBoundsPossessionChange : MonoBehaviour
{
    //initialize variables
    public string PlayerState;
    public string ComputerState;

    //this function switches the possession of the ball and reset all values related to being on a specific possession
    public void OnCollisionEnter()
    {
        PlayerState = GetString("PlayerState");
        ComputerState = GetString("ComputerState");

        if (PlayerState == "Offense" || ComputerState == "Defense")
        {
            SetString("PlayerState", "Defense");
            SetString("ComputerState", "Offense");
        }
        else if (PlayerState == "Defense" || ComputerState == "Offense")
        {
            SetString("PlayerState", "Offense");
            SetString("ComputerState", "Defense");
        }
        else
        {
            SetString("PlayerState", "Offense");
            SetString("ComputerState", "Defense");
        }

        SetString("Block", "");
        SetString("Shoot", "");
        PlayerPrefs.SetFloat("TimeShootButtonHeldFor", 0f);
        SetString("Distance", "");
        SetString("OpponentShoot", "");
        PlayerPrefs.SetInt("InvokedTimes", 0);
    }

    //this function retrieves the value stored under a specific keyname in the playerprefs dictionary
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
