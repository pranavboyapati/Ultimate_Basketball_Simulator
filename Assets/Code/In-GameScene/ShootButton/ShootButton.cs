//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ShootButton : MonoBehaviour
{
    //this function updates the values of the variables that control the behavior when the shoot button is pressed
    public async void Shoot()
    {
        PlayerPrefs.SetString("Shoot", "True");
        PlayerPrefs.SetString("PlayerState", "");
        await Task.Delay(500);
        PlayerPrefs.SetString("Shoot", "False");
    }
}
