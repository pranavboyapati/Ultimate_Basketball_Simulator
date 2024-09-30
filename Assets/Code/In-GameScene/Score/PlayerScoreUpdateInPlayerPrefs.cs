//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreUpdateInPlayerPrefs : MonoBehaviour
{
    //initialize variables
    public int playerScore;
    public GameObject basketball;
    public Collider leftHoopCollider;
    
    //this function adds to the players score when they make the ball into the basket
    public void OnCollisionEnter()
    {
        if (basketball.transform.position.z <= -6 && basketball.transform.position.y >= 20)
        {
            playerScore = GetInt("PlayerScore");
            playerScore += 1;
            SetInt("PlayerScore", playerScore);
            PlayerPrefs.SetString("PlayerState", "Defense");
            PlayerPrefs.SetString("ComputerState", "Offense");
            SetString("Block", "");
            SetString("Shoot", "");
            PlayerPrefs.SetFloat("TimeShootButtonHeldFor", 0f);
            SetString("Distance", "");
            SetString("OpponentShoot", "");
            PlayerPrefs.SetInt("InvokedTimes", 0);
            leftHoopCollider.enabled = !leftHoopCollider.enabled;
        }

        if (basketball.transform.position.z >= -2)
        {
            if (leftHoopCollider.enabled == false)
            {
                leftHoopCollider.enabled = !leftHoopCollider.enabled;
            }
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyName)
    {
        return PlayerPrefs.GetInt(keyName);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string keyName, int value)
    {
        PlayerPrefs.SetInt(keyName, value);
    }
    
    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
