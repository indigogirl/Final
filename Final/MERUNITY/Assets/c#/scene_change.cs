using UnityEngine;
using System.Collections;

public class scene_change : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel ("inside_ship"); //load the scene #1 in "File >>BuildSettings"        
		}
		
	}
}
