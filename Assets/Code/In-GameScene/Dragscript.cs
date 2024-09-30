//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;

public class Dragscript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	//initialize variables
	public Camera MainCamera;
	public GameObject player;
	public Animator playerAnimator;
	public RuntimeAnimatorController None;
	public RuntimeAnimatorController run;
	Vector3 move;
	Vector3 initialpos;
	Vector3 distance;
	
	//this function is called once when the page is first loaded
	//this function initializes a variable for storing joystick input
	void Start()
	{
		move = Vector3.zero;
	}
	
	//this function is called once per frame update
	//this function translates the player and camera based on joystick input
	void Update()
	{
		player.transform.position += move * Time.deltaTime * 4;
		MainCamera.transform.position += move * Time.deltaTime * 4;
	}

	//this function handles when the joystick is first dragged from its initial position
	#region IBeginDragHandler implementation
	public void OnBeginDrag(PointerEventData eventData)
	{
		initialpos = transform.position;
		move = Vector3.zero;
		playerAnimator.runtimeAnimatorController = run;
	}
	#endregion

	//this function handles when the joystick is continuing to be dragged
	#region IDragHandler implementation
	public void OnDrag(PointerEventData eventData)
	{
		distance = Input.mousePosition - initialpos;
		distance = Vector3.ClampMagnitude(distance, 45 * Screen.width / 708);
		transform.position = initialpos + distance;
		move = distance.normalized;
	}

	#endregion

	//this function handles when the joystick is released and no longer is being dragged
	#region IEndDragHandler implementation
	public void OnEndDrag(PointerEventData eventData)
	{
		move = Vector3.zero;
		transform.position = initialpos;
		playerAnimator.runtimeAnimatorController = None;
	}


	#endregion

}
