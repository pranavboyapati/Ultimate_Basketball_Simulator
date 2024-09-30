//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsTextChanger : MonoBehaviour
{
    //initialize variables
    public int coins;
    public string coinsAsString;

    //this function is called upon per frame update
    //this function updates the display for the number of coins the user has
    public void Update()
    {
        coins = GetInt("Coins");
        coinsAsString = coins.ToString();

        GetComponent<UnityEngine.UI.Text>().text = "Coins: " + coinsAsString;
    }

    //this function retreives the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
