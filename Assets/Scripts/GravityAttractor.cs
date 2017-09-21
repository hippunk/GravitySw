using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour {

	public float attractorForce = 9.81f;
	//public Vector2 attractorGravity = new Vector2 (-9.81f,0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerEnter2D(Collider2D collider){
		GravitySensitive gs = collider.gameObject.GetComponent<GravitySensitive> ();

		gs.sensitive = false;
		gs.oldGravity = gs.gravity;

	}
	void OnTriggerStay2D(Collider2D collider){
		GravitySensitive gs = collider.gameObject.GetComponent<GravitySensitive> ();
		//Newtown lax mass relaxed 
		Vector2 attractorGravity = (this.transform.position - gs.transform.position).normalized * attractorForce;
		gs.gravity = (new Vector2(gs.oldGravity.x+attractorGravity.x,gs.oldGravity.y+attractorGravity.y))/Mathf.Pow(Vector2.Distance(this.transform.position,gs.transform.position),2.0f);
		

	}

	void OnTriggerExit2D(Collider2D collider){
		GravitySensitive gs = collider.gameObject.GetComponent<GravitySensitive> ();
		gs.sensitive = true;
		gs.gravity = gs.oldGravity;
		//gs.gravity = (gs.transform.position - this.transform.position).normalized;


	}
}
