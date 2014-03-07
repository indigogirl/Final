using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//change the scene after 60 seconds
		if (Time.time > 60f) {
			Application.LoadLevel ("dancingBaby");		
			Application.LoadLevel (1); //load the scene #1 in "File >>BuildSettings"
		}
		//dancingBaby is name of next scene file
		    //Time.time a float keeping track of time, 

	if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel (1); //load the scene #1 in "File >>BuildSettings"		
		}

	}
}
