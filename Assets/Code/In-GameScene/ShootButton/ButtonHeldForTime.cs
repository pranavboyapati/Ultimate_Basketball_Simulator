//import libraries
using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine.EventSystems;
 
public class ButtonHeldForTime : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    //initialize variables
    public bool buttonPressed;
    public float timeHeld = 0f;
 
    //this function tells the timer to start
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
 
    //this function tells the timer to stop
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    //this function is called once per frame update
    //this function determines the time the shoot button was pressed for, which determines the strength of the shot
    public void Update()
    {
        if (buttonPressed == true)
        {
            timeHeld += Time.deltaTime;
            PlayerPrefs.SetFloat("TimeShootButtonHeldFor", timeHeld);
        }
        if (buttonPressed == false)
        {
            timeHeld = 0f;
        }
    }
}