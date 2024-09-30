//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDribble : MonoBehaviour
{
    //initialize variables
    public string playerState;
    public GameObject player;
    public GameObject basketball;

    //this function is called on the interval specified in the project settings file
    //this function determines whether the player is on offense or defense
    public void FixedUpdate()
    {
        playerState = GetString("PlayerState");
    }

    //this function is called once per frame update
    //this function has the player dribble the ball when on offense
    public void Update()
    {
        if (playerState == "Offense")
        {
            Vector3 CurrentPosition = transform.position;
            CurrentPosition.x = player.GetComponent<Transform>().position.x;
            CurrentPosition.y = player.GetComponent<Transform>().position.y;
            CurrentPosition.z = basketball.GetComponent<Transform>().position.z;
            basketball.transform.position = CurrentPosition;
        }
    }

    //this function retrieves the value stored under the specified keyname in the player prefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
