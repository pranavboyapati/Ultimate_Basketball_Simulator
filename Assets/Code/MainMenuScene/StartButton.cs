//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //this function changes the page to the basketball game and initializes default values for that page
    public void StartButtonClick()
    {
        SceneManager.LoadScene("InGameScene");
        PlayerPrefs.SetString("PlayerState", "Offense");
        PlayerPrefs.SetString("ComputerState", "Defense");
    }
}
