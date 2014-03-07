using UnityEngine;
using System.Collections;

public class PhysicsDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// FixedUpdate is called every 0.2 seconds
	//FixedUpdate is almost exclusively for running physics
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.Space) ) {
						rigidbody.AddForce (transform.up * 20f, ForceMode.Acceleration);
				}

		//long hand: GetComponent<Rigidbody> ().AddForce (GetComponent<Transform> ().up *10f);
		//f means it's a float
		//. let's us access any members of the thing before it, ie access rigidbody
		//shortcut :: rigidbody.AddForce (new Vector3 (0f,10f,0f));
		//shortcut :: rigidbody.AddForce (transform.up);

		if (Input.GetKey (KeyCode.UpArrow) ) {
						rigidbody.AddForce (transform.forward * 5f);
				}

		if (Input.GetKey (KeyCode.LeftArrow) ) {
			rigidbody.AddForce (-transform.right * 5f);

			//theres no "left", you type in -right
		}
	}
}
