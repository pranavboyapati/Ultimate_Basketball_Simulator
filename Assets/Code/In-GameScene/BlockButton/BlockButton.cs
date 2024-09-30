//import libraries
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockButton : MonoBehaviour
{
    //this function changes the value of the blocking behavior control variable
    public async void Block()
    {
        PlayerPrefs.SetString("Block", "True");
        await Task.Delay(500);
        PlayerPrefs.SetString("Block", "False");
    }
}
