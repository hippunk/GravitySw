using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySensitive : MonoBehaviour {

	public Vector2 gravity = Vector2.down;
	public Vector2 oldGravity = Vector2.down; //choice of memory cost rather than cpu time, better find another solution for this one.
	public bool sensitive = true;
	public float sensitivity = 9.8f;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
			GetComponent<Rigidbody2D> ().AddForce (gravity);
	}
		
}
