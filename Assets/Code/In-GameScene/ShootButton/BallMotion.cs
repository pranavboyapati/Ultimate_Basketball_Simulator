//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotion : MonoBehaviour
{
    //initialize variables
    public string WhetherBallShot;
    public float zPositionBall;
    public float TimeButtonHeldFor;
    public GameObject Basketball;
    public float Gravity = 9.81f;
    public float xVelocity;
    public float yVelocity;

    //this function determines the balls velocity when shot
    public void MoveBall()
    {
        WhetherBallShot = GetString("Shoot");

        if (WhetherBallShot == "True")
        {
            TimeButtonHeldFor = GetFloat("TimeShootButtonHeldFor");

            xVelocity = 50 * TimeButtonHeldFor;
            yVelocity = -50 * TimeButtonHeldFor;
        }
    }

    //this function translates the ball when it is shot
    public void Update()
    {
        Basketball.transform.Translate(0, xVelocity * Time.deltaTime, yVelocity * Time.deltaTime, Space.World);
        
        if (yVelocity < 0f)
        {
            yVelocity += (Gravity * Time.deltaTime);
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public float GetFloat(string Keyname)
    {
        return PlayerPrefs.GetFloat(Keyname);
    }
}
