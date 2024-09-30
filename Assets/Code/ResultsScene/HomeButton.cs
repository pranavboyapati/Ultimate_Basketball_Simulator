//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    //initialize variables
    public int playerScore;
    public int coinsWon;
    public int totalCoins;
    
    //this function ensures all values that changed during gameplay are updated and loads the main menu
    public void HomeClicked()
    {
        playerScore = GetInt("PlayerScore");
        coinsWon = playerScore * 20;
        totalCoins = GetInt("Coins");
        totalCoins += coinsWon;
        SetInt("Coins", totalCoins);

        SetInt("PlayerScore", 0);
        SetInt("ComputerScore", 0);
        
        SceneManager.LoadScene("MainMenuScene");
    }

    //this function retreives the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }
}
