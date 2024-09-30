//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHornethsButtonText : MonoBehaviour
{           
    //initialize variables
    public string HornethsOwned;
    public string selectedTeam;
    public string insufficientCoins;
    
    //this function is called once per frame update
    //this function updates the button text to tell the user whether they own the team, have the team selected, or can't afford the team
    public void Update()
    {
        HornethsOwned = GetString("HornethsOwned");
        if (HornethsOwned == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Team Owned";
        }

        selectedTeam = GetString("SelectedTeam");
        if (selectedTeam == "Horneths")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Team Selected";
        }

        insufficientCoins = GetString("NotEnoughCoinsForHorneths");
        if (insufficientCoins == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Not Enough Coins";
            Invoke("RestorePreviousText", 3.0f);
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

    //this function restores the purchase text when the user's attempted purchase fails
    public void RestorePreviousText()
    {
        SetString("NotEnoughCoinsForHorneths", "False");
        GetComponent<UnityEngine.UI.Text>().text = "Buy For 8000 Coins";
    }
}
