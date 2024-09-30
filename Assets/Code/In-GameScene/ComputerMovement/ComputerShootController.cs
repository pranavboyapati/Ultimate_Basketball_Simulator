//import libraries
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ComputerShootController : MonoBehaviour
{
    //initialize variables
    public string Distance;
    public float DistanceAsFloat;
    public GameObject ButtonForOpponentShoot;

    //this function controls when the computer character shoots the ball
    public async void ComputerShoot()
    {
        Distance = GetString("Distance");
        try
        {
            DistanceAsFloat = (float)Convert.ToDecimal(Distance, CultureInfo.GetCultureInfo("en-US"));
        }
        catch
        {
        }
        
        

        if (DistanceAsFloat <= 7)
        {
            PlayerPrefs.SetString("OpponentShoot", "True");
            PlayerPrefs.SetString("Distance", "");
            PlayerPrefs.SetString("ComputerState", "");
            await Task.Delay(500);
            PlayerPrefs.SetString("OpponentShoot", "False");
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
