using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float movementSpeed = 600f;
	private float movement = 0f;
	
	// Update is called once per frame
	void Update () {

		movement = -Input.GetAxisRaw("Horizontal") * movementSpeed;
	}

	private void FixedUpdate() {

		transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		
		SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
	}
}
