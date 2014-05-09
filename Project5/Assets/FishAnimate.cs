using UnityEngine;
using System.Collections;

public class FishAnimate : MonoBehaviour {

	public Animation animationComponent; //assign in inspector

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//access data of (1) how fast the fish is movie, then (2) how do i control how fast the fish animates?

		float speed = rigidbody.velocity.magnitude; //took length of velocity vector to know how fast the fish is moving

		animationComponent["swimLoop"].speed = speed; //get reference to an animation compenent, access the clip you want to modify, then manipulate the speed value
	}
}
