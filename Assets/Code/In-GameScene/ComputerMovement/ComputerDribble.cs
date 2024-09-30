//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerDribble : MonoBehaviour
{
    //initialize variables
    public string computerState;
    public GameObject computer;
    public GameObject basketball;

    //this function is called on the interval specified in the player settings file
    //this function checks whether the computer is on offense
    public void FixedUpdate()
    {
        computerState = GetString("ComputerState");
    }

    //this function is called once per frame update
    //this function controls the dribbling of the ball when the computer is on offense
    public void Update()
    {
        if (computerState == "Offense")
        {
            Vector3 CurrentPosition = transform.position;
            CurrentPosition.x = computer.GetComponent<Transform>().position.x;
            CurrentPosition.y = computer.GetComponent<Transform>().position.y;
            CurrentPosition.z = basketball.GetComponent<Transform>().position.z;
            basketball.transform.position = CurrentPosition;
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
