//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class BlockButtonArmRotation : MonoBehaviour
{
    //initialize variables
    public GameObject playerLeftArm;
    public GameObject playerRightArm;

    //this function rotates the players arms upwards to block the ball and then back down
    public async void RotateOnClick()
    {
        playerLeftArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        playerRightArm.transform.localRotation = Quaternion.Euler(0, 90, 0);
        await Task.Delay(1100);
        playerLeftArm.transform.localRotation = Quaternion.Euler(85.324f, 76.346f, 81.901f);
        playerRightArm.transform.localRotation = Quaternion.Euler(274.676f, 76.346f, -81.901f);
    }
}
