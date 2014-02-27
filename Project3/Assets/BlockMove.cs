using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-2f, 0f, 0f);
	}
}