using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour {

	private Vector2 currentGravity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			changeGravity (new Vector2 (-1.0f, 0.0f));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			changeGravity (new Vector2 (1.0f, 0.0f));
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			changeGravity (new Vector2 (0.0f, 1.0f));
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			changeGravity (new Vector2 (0.0f, -1.0f));
		}
	}


	void changeGravity(Vector2 gravity){
		foreach (GravitySensitive gs in FindObjectsOfType<GravitySensitive>()) {
			if(gs.sensitive)
				gs.gravity = gravity*gs.sensitivity;
		}
	}
}
