//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreDisplayText : MonoBehaviour
{
    //initialize variables
    public int playerScore;
    public int computerScore;
    
    //this function is called once when the page is first loaded
    //this function displays the final score
    public void Start()
    {
        playerScore = GetInt("PlayerScore");
        computerScore = GetInt("ComputerScore");

        GetComponent<UnityEngine.UI.Text>().text = "Final Score: " + playerScore + " - " + computerScore;
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
