//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentShootCharacterMovement : MonoBehaviour
{
    //initialize variables
    public string WhetherToJumpOpponent;
    public float OpponentVelocity;
    public GameObject ComputerizedOpponent;
    public float OpponentZposition;
    public float gravity = -9.81f;
    
    //this function is called once per frame update
    //this function controls the jump motion of the computer character when they shoot the ball
    public void Update()
    {
        WhetherToJumpOpponent = GetString("OpponentShoot");

        OpponentVelocity = -5f;

        if (WhetherToJumpOpponent == "True")
        {
            ComputerizedOpponent.transform.Translate(0, 0, OpponentVelocity * Time.deltaTime, Space.World);
        }
        else if (WhetherToJumpOpponent == "False")
        {
            OpponentZposition = ComputerizedOpponent.GetComponent<Transform>().position.z;
            OpponentVelocity += gravity * Time.deltaTime;

            if (OpponentZposition < 0)
            {
                ComputerizedOpponent.transform.Translate(0, 0, OpponentVelocity * Time.deltaTime * -1, Space.World);
            }
            else if (OpponentZposition >= 0)
            {
                SetString("OpponentShoot", "");
            }
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
