//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScoreUpdateInPlayerPrefs : MonoBehaviour
{
    //initialize variables
    public int computerScore;
    public GameObject basketball;
    public Collider rightHoopCollider;

    //this function adds to the computers score when they make the ball into the basket
    public void OnCollisionEnter()
    {
        if (basketball.transform.position.z <= -6 && basketball.transform.position.y <= -20)
        {
            computerScore = GetInt("ComputerScore");
            computerScore += 1;
            SetInt("ComputerScore", computerScore);
            PlayerPrefs.SetString("PlayerState", "Offense");
            PlayerPrefs.SetString("ComputerState", "Defense");
            SetString("Block", "");
            SetString("Shoot", "");
            PlayerPrefs.SetFloat("TimeShootButtonHeldFor", 0f);
            SetString("Distance", "");
            SetString("OpponentShoot", "");
            PlayerPrefs.SetInt("InvokedTimes", 0);
            rightHoopCollider.enabled = !rightHoopCollider.enabled;
        }

        if (basketball.transform.position.z >= -2)
        {
            if (rightHoopCollider.enabled == false)
            {
                rightHoopCollider.enabled = !rightHoopCollider.enabled;
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
