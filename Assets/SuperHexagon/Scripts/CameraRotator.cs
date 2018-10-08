using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour {

	public float rotationSpeed = 1f;

	// Update is called once per frame
	void FixedUpdate () {
		
		transform.Rotate( Vector3.forward, rotationSpeed * Time.deltaTime );
	}
}
