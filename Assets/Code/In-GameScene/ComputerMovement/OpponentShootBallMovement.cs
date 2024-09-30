//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentShootBallMovement : MonoBehaviour
{
    //initialize variables   
    public GameObject Basketball;
    public float BallXVelocity;
    public float BallYVelocity;
    public float Gravity = 9.81f;
    public string WhetherToJumpOpponent;
    public float RandomFloat;
    
    //this function is called once per frame update
    //this function translates the ball once the computer character shoots it
    public void Update()
    {
        Basketball.transform.Translate(0, BallXVelocity * Time.deltaTime, BallYVelocity * Time.deltaTime, Space.World);
        
        if (BallYVelocity < 0f)
        {
            BallYVelocity += (Gravity * Time.deltaTime);
        }
    }

    //this function determines the speed at which the ball is shot
    public void SetBallVelocities()
    {
        WhetherToJumpOpponent = GetString("OpponentShoot");

        if (WhetherToJumpOpponent == "True")
        {    
            RandomFloat = Random.Range(-5.0f, -20.0f);
            
            BallXVelocity = RandomFloat;
            BallYVelocity = RandomFloat;
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}
