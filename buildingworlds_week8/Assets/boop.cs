using UnityEngine;
using System.Collections;

public class boop : MonoBehaviour {
	public Transform ball1, ball2; //assign in inspector
	// Use this for initialization
	void Start () {
		//call BallSwap in special way for coroutines
		StartCoroutine (BallSwap ());
	}

	IEnumerator BallSwap (){
		Debug.Log ("the coroutine started!");
		//to tell unity to wait temporarily (one frame):
		yield return 0;
		Debug.Log ("one frame elapsed!");
		yield return 0;
		yield return null; //this tells us to wait two frames // 0 and null are the same thing..?
		Debug.Log ("two frames elapsed!");

		yield return new WaitForSeconds (2.0f);
		Debug.Log ("two seconds elapsed!"); //if you're choreographing a music video... wait two seconds! now turn on spotlight.. etc
	
		while (true) { //true is always going to be true, this makes it an infinite loop..?
						float time = 0f;
						Vector3 originalBall1Pos = ball1.position;
						Vector3 originalBall2Pos = ball2.position;
						while (time < 1f) { //loop while time is less than one
								time += Time.deltaTime; //adding time gradually
	

								ball1.position = Vector3.Lerp (originalBall1Pos, originalBall2Pos, time); //lerp is linear interpolation = smoothing = blending
								ball2.position = Vector3.Lerp (originalBall2Pos, originalBall1Pos, time);
								//color.Lerp


								if (time >= 0.49f && time <= 0.51f) { //if statements without curly brackets, then only the next line is applied
										audio.Play ();
										StartCoroutine (ScreenShake ());

								}
								yield return 0; //wait a frame -- this is what makes the infinite loop okay
						}
				}
			}

	IEnumerator ScreenShake(){
		float time = 0.3f; //this is a different time than above, unity knows this because it's in a differnt scope
		Vector3 originalCamPosition = Camera.main.transform.position;
		while (time > 0f) {
			time -= Time.deltaTime; //
			
			Camera.main.transform.position = originalCamPosition 
									+ Vector3.up* Mathf.Sin (Time.time* 100f) *time
									+ Vector3.right*Mathf.Sin (Time.time*113f)*time;
			yield return 0;
		}
	}
}

//co routines = tell unity to go slower, a function can now last longer than a frame, tell function how fast to execute

//ienumerator is what makes a coroutine