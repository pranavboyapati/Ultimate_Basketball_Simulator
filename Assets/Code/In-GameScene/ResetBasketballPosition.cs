//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBasketballPosition : MonoBehaviour
{
    //initialize variables
    public GameObject Basketball;  

    //this function is called once per frame update
    //this function resets the ball to the center of the court if necessary 
    public void Update()
    {
        Vector3 CurrentPosition = transform.position;
        CurrentPosition.x = Basketball.GetComponent<Transform>().position.x;
        CurrentPosition.y = Basketball.GetComponent<Transform>().position.y;
        CurrentPosition.z = Basketball.GetComponent<Transform>().position.z;

        if (CurrentPosition.z > 3)
        {
            CurrentPosition.x = -10.9f;
            CurrentPosition.y = 7f;
            CurrentPosition.z = -5f;
            Basketball.transform.position = CurrentPosition;
        }
    }
}
