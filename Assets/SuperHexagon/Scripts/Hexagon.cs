using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

	public float speed = 5.0f;
	public float startScale = 10.0f;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
		transform.localScale = Vector3.one * startScale;
		rb.rotation = Random.Range(0f, 360f);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.localScale -= Vector3.one * speed * Time.deltaTime;

		if( transform.localScale.x <= 0.05 ) {

			Destroy( this.gameObject );
		}
	}
}
