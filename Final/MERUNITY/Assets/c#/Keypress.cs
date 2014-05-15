using UnityEngine;
using System.Collections;

public class Keypress : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody.AddForce (-transform.right * 15f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody.AddForce (transform.right * 15f);
		}
		
	}
}

