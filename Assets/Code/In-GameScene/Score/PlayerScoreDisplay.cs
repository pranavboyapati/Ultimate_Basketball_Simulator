//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreDisplay : MonoBehaviour
{
    //initialize variables
    public int PlayerScore;
    public string PlayerScoreString;
    public string PlayerTeam;

    //this function is called once per frame update
    //this function updates the player score display
    public void Update()
    {
        PlayerScore = GetInt("PlayerScore");
        PlayerScoreString = PlayerScore.ToString();
        PlayerTeam = GetString("SelectedTeam");
        GetComponent<UnityEngine.UI.Text>().text = PlayerTeam + ": " + PlayerScoreString;
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
}
