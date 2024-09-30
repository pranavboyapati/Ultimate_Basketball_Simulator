//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ShootButtonPlayerArmRotation : MonoBehaviour
{
    //initialize variables
    public GameObject PlayerLeftArm;
    public GameObject PlayerRightArm;
    
    //this function rotates the player's arms when they shoot the ball
    public async void Rotate()
    {
        PlayerLeftArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        PlayerRightArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        await Task.Delay(1100);
        PlayerLeftArm.transform.localRotation = Quaternion.Euler(85.324f, 76.346f, 81.901f);
        PlayerRightArm.transform.localRotation = Quaternion.Euler(274.676f, 76.346f, -81.901f);
    }
}
