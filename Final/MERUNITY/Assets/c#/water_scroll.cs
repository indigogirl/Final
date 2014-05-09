using UnityEngine;
using System.Collections;

public class water_scroll : MonoBehaviour {

	public float waterScrollSpeed=0.01f;
	
	// Update is called once per frame
	void Update () {
		Vector2 newOffset = new Vector2 (Time.time, Mathf.Sin(Time.time))*waterScrollSpeed;
		renderer.material.mainTextureOffset = newOffset;

	}
}
