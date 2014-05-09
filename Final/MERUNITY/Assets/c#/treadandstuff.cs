using UnityEngine;
using System.Collections;

public class treadandstuff : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			//then dance
			GetComponent<Animator> ().SetBool ("tread",true);
		}
		else {
			//otherwise, don't dance
			GetComponent<Animator>().SetBool ("tread",false);
		}
	}
}
