//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockButtonMovement : MonoBehaviour
{
    //initialize variables
    public string WhetherToJump;
    public float velocity;
    public float gravity = -9.81f;
    public float Zposition;
    public GameObject player;
    public Camera MainCamera;

    //this function is called once per frame update
    //this function controls the player character's jump behavior as they attempt to block the ball
    public void Update()
    {
        WhetherToJump = GetString("Block");
        velocity = -5f;
        if (WhetherToJump == "True")
        {
            player.transform.Translate(0, 0, velocity * Time.deltaTime, Space.World);
            MainCamera.transform.Translate(0, 0, velocity * Time.deltaTime, Space.World);
        }
        
        if (WhetherToJump == "False")
        {
            Zposition = player.GetComponent<Transform>().position.z;
            velocity += gravity * Time.deltaTime;

            if (Zposition < 0)
            {
                player.transform.Translate(0, 0, velocity * Time.deltaTime * -1, Space.World);
                MainCamera.transform.Translate(0, 0, velocity * Time.deltaTime * -1, Space.World);
            }

            if (Zposition > 0)
            {
                PlayerPrefs.SetString("Block", "");
            }
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }
}
