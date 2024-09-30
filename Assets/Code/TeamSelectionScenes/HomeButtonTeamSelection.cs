//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonTeamSelection : MonoBehaviour
{
    //this function loads the main menu page
    public void Clicked()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
