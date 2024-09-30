//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class OpponentArmRotation : MonoBehaviour
{
    //initialize variables
    public GameObject OpponentLeftArm;
    public GameObject OpponentRightArm;
    
    //this function rotates the opponent's arms as they try to block the ball when the player shoots it
    public async void Rotate()
    {
        OpponentRightArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        OpponentLeftArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        await Task.Delay(1100);
        OpponentLeftArm.transform.localRotation = Quaternion.Euler(85.324f, 76.346f, 81.901f);
        OpponentRightArm.transform.localRotation = Quaternion.Euler(274.676f, 76.346f, -81.901f);
    }
}
