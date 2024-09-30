//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerScoreDisplay : MonoBehaviour
{
    //initialize variables
    public int ComputerScore;
    public string ComputerScoreString;
    
    //this function is called once per frame update
    //this function updates the computer score display
    public void Update()
    {
        ComputerScore = GetInt("ComputerScore");
        ComputerScoreString = ComputerScore.ToString();
        GetComponent<UnityEngine.UI.Text>().text = "Computer: " + ComputerScoreString;
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
