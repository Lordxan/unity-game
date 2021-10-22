using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2D controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = (Mathf.Clamp(Input.GetAxisRaw("Horizontal") + CustomInput.GetHorizontalAxis(), -1, 1)) * runSpeed;

		if (Input.GetButtonDown("Jump") || CustomInput.IsJump())
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
		CustomInput.SetJump(false);
	}
}
