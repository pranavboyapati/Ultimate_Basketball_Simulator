//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsWonDisplayText : MonoBehaviour
{
    //initialize variables
    public int playerScore;
    public int coinsWon;
    
    //this function is called once when the page is first loaded
    //this function calculates how many coins the player won based on their score, displays this, and updates the coins value in the playerprefs dictionary
    public void Start()
    {
        playerScore = GetInt("PlayerScore");
        coinsWon = playerScore * 20;

        GetComponent<UnityEngine.UI.Text>().text = "Coins Won: " + coinsWon;
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
