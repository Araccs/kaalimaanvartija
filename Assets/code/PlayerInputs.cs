using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace kaalimaanvartija
{
	public class PlayerInputs : MonoBehaviour
	{
	
		
		[SerializeField]
		private float velocity = 1;
		private Vector2 moveInput;

		
		private void Update()
		{
		
			Vector2 movement = moveInput * Time.deltaTime * velocity;
			transform.Translate(movement);

			
		}

		private void OnMove(InputAction.CallbackContext callbackContext)
		{
			moveInput = callbackContext.ReadValue<Vector2>();
			
		}

		private void OnJump(InputAction.CallbackContext callbackContext)
		{
			InputActionPhase inputPhase = callbackContext.phase;
			Debug.Log("Jump input phase: " + inputPhase);
		}
	}
}
