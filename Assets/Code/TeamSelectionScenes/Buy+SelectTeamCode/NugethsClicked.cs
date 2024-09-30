//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NugethsClicked : MonoBehaviour
{
    //initialize variables
    public int coins;
    public string NugethsOwned;
    
    //this function allows the user to purchase the team if the user has enough coins and doesn't already own the team, selects the team if
    //it is already owned, or tells the user they don't have enough coins to purchase the team if they don't own the team and can't buy it yet
    public void Clicked()
    {
        coins = GetInt("Coins");
        NugethsOwned = GetString("NugethsOwned");

        if (NugethsOwned == "True")
        {
            SetString("SelectedTeam", "Nugeths");
        }

        if (coins >= 8000)
        {
            if (NugethsOwned == "False")
            {
                coins -= 8000;
                SetInt("Coins", coins);
                SetString("NugethsOwned", "True");
            }
        }
        else
        {
            if (NugethsOwned == "False")
            {
                SetString("NotEnoughCoinsForNugeths", "True");
            }
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
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

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }
}
