/*
 *Project: Third Person Character Controller with 2 Cameras
 *Coder: Dani Moss
 *Tutorial used: Grim Grin Gaming: Character Controller Movement and Camera - Unity 3D with C# Programming
 *Tutorial URI: http://youtu.be/vPOKZ62SAiI
 *Complete: 14 May 2014
 */

using UnityEngine;
using System.Collections;

//all objects using this class must have a character controller attached
[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour 
{

	//Variables
	public float moveSpeed;
	public float rotationSpeed;
	CharacterController character;

	// Use this for initialization
	void Start () 
	{
		character = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//move character
		Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * moveSpeed;
		character.Move(forward * Time.deltaTime);

		//rotate character
		transform.Rotate(new Vector3 (0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0) );

		//add gravity to character
		character.SimpleMove(Physics.gravity);
	}
}
