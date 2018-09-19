using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed = 20.0f;
	private Vector3 direction;
	private CharacterController characterController;

	public Camera cam;


	private float distance = 30f;

	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		direction.x = Input.GetAxis ("Horizontal");
		direction.z = Input.GetAxis ("Vertical");

		Vector3 moveDirection = new Vector3 (direction.x, 0, direction.z);
		characterController.SimpleMove (moveDirection * moveSpeed);

	}
}
