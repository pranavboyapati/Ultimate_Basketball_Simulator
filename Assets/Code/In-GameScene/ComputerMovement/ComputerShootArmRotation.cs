//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ComputerShootArmRotation : MonoBehaviour
{  
    //initialize variables
    public GameObject OpponentLeftArm;
    public GameObject OpponentRightArm;

    //this function controls the arm rotation and movement of the computer character as the ball is shot
    public async void OpponentArmRotate()
    {
        OpponentLeftArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        OpponentRightArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        await Task.Delay(1100);
        OpponentLeftArm.transform.localRotation = Quaternion.Euler(85.324f, 76.346f, 81.901f);
        OpponentRightArm.transform.localRotation = Quaternion.Euler(274.676f, 76.346f, -81.901f);
    }
}
