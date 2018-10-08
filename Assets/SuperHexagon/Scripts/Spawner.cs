using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float spawnRate = 1f;
	public GameObject hexPrefab;

	private float nextSpawnTime = 0f;
	
	// Update is called once per frame
	void Update () {
		
		if(Time.time >= nextSpawnTime) {
			Instantiate(hexPrefab, Vector3.zero, Quaternion.identity);
			nextSpawnTime = Time.time + 1f / spawnRate;
		}
	}
}
