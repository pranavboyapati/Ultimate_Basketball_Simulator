//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButtonMovement : MonoBehaviour
{   
    //initialize variables
    public string WhetherToJump;
    public float velocity;
    public float gravity = -9.81f;
    public float Zposition;
    public GameObject opponent;

    //this function is called once per frame update
    //this function controls the computer's jump movement as they try to block the ball when it is shot by the player
    public void Update()
    {
        WhetherToJump = GetString("Shoot");
        velocity = -5f;
        if (WhetherToJump == "True")
        {
            opponent.transform.Translate(0, 0, velocity * Time.deltaTime, Space.World);
        }
        
        if (WhetherToJump == "False")
        {
            Zposition = opponent.GetComponent<Transform>().position.z;
            velocity += gravity * Time.deltaTime;

            if (Zposition < 0)
            {
                opponent.transform.Translate(0, 0, velocity * Time.deltaTime * -1, Space.World);
            }
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
