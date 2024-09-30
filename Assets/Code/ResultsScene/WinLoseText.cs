//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseText : MonoBehaviour
{
    //initialize variables
    public int playerScore;
    public int computerScore;
    
    //this function is called once when the page is first laoded
    //this function tells the player whether they won or lost the game
    public void Start()
    {
        playerScore = GetInt("PlayerScore");
        computerScore = GetInt("ComputerScore");

        if (playerScore > computerScore)
        {
            GetComponent<UnityEngine.UI.Text>().text = "You Won!";
        }

        else if (playerScore == computerScore)
        {
            GetComponent<UnityEngine.UI.Text>().text = "Draw!";
        }

        else
        {
            GetComponent<UnityEngine.UI.Text>().text = "You Lost!";
        }    
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
