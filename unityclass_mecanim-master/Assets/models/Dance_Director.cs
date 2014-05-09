using UnityEngine;
using System.Collections;

public class Dance_Director : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.Space)) {
			//then dance
						GetComponent<Animator> ().SetBool ("ShouldiDance", true);
				}
		else {
			//otherwise, don't dance
			GetComponent<Animator>().SetBool ("ShouldiDance",false);
	}
}
}
