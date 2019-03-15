using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControlInClass : MonoBehaviour
{

	public UnityEvent OnGrounded;
	public UnityEvent OffGrounded;

	public float Speed = 5f;
	public float Gravity = -9.81f;
	public float JumpForce = 2f;
	
	private CharacterController controller; //This didn't have to be public as it no longer needs to be accessed in the editor.

	private Vector3 position; //Its generally best if as many variables as possible are private.
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>(); //This will prevent a null reference exception.
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (controller.isGrounded)
		{
			OnGrounded.Invoke();
		}
		else
		{
		 OffGrounded.Invoke();
		}

		if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
		{
			position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
		}
		else
		{
			position.y = Gravity * Time.deltaTime;	
		}
//		if (controller.isGrounded && Input.GetButton("Jump"))
//		{
//			position.y = JumpForce;  //This doesn't work quite right.
//		}
		
		position.y += Gravity * Time.deltaTime;
		
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		
		controller.Move(position); //This will put the ship in the 0,0,0 position. This is what is actually making it move...
	}
}
