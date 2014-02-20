using UnityEngine;
using System.Collections;

public class Script2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int buffer= 150;

		float x, y, z;
		x = Camera.main.gameObject.transform.position.x;
		y = Camera.main.gameObject.transform.position.y;
		z = Camera.main.gameObject.transform.position.z;

		int text1_x = 1147;
		int text1_y = 100;
		int text1_z = 704;

		if (x > (text1_x - buffer) && x < (text1_x + buffer)) {
			if (y > (text1_y - buffer) && y < (text1_y + buffer)) {
				if (z > (text1_z - buffer) && z < (text1_z + buffer)){

					if (Input.GetKeyDown (KeyCode.Y)) {
						Camera.main.gameObject.transform.position =new Vector3 (974,98,878);
				
					}
					}
			}
		}

		if (x > (text1_x - buffer) && x < (text1_x + buffer)) {
			if (y > (text1_y - buffer) && y < (text1_y + buffer)) {
				if (z > (text1_z - buffer) && z < (text1_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.N)) {
						Camera.main.gameObject.transform.position =new Vector3 (1346,220,188);
						
					}
				}
			}
		}

		int text2_x = 1346;
		int text2_y = 220;
		int text2_z = 188;

		if (x > (text2_x - buffer) && x < (text2_x + buffer)) {
			if (y > (text2_y - buffer) && y < (text2_y + buffer)) {
				if (z > (text2_z - buffer) && z < (text2_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.Y)) {
						Camera.main.gameObject.transform.position =new Vector3 (1147,100,704);
						
					}
				}
			}
		}
		
		if (x > (text2_x - buffer) && x < (text2_x + buffer)) {
			if (y > (text2_y - buffer) && y < (text2_y + buffer)) {
				if (z > (text1_z - buffer) && z < (text2_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.N)) {
						Camera.main.gameObject.transform.position =new Vector3 (727,470,991);
						
					}
				}
			}
		}

		int text3_x = 974;
		int text3_y = 98;
		int text3_z = 878;
		
		if (x > (text3_x - buffer) && x < (text3_x + buffer)) {
			if (y > (text3_y - buffer) && y < (text3_y + buffer)) {
				if (z > (text3_z - buffer) && z < (text3_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.Y)) {
						Camera.main.gameObject.transform.position =new Vector3 (678,162,1140);
						
					}
				}
			}
		}
		
		if (x > (text3_x - buffer) && x < (text3_x + buffer)) {
			if (y > (text3_y - buffer) && y < (text3_y + buffer)) {
				if (z > (text3_z - buffer) && z < (text3_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.N)) {
						Camera.main.gameObject.transform.position =new Vector3 (1346,220,188);
						
					}
				}
			}
		}


		int text4_x = 678;
		int text4_y = 162;
		int text4_z = 1140;
		
		if (x > (text4_x - buffer) && x < (text4_x + buffer)) {
			if (y > (text4_y - buffer) && y < (text4_y + buffer)) {
				if (z > (text4_z - buffer) && z < (text4_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.Y)) {
						Camera.main.gameObject.transform.position =new Vector3 (1346,220,188);
						
					}
				}
			}
		}


		if (x > (text4_x - buffer) && x < (text4_x + buffer)) {
			if (y > (text4_y - buffer) && y < (text4_y + buffer)) {
				if (z > (text4_z - buffer) && z < (text4_z + buffer)){
					
					if (Input.GetKeyDown (KeyCode.N)) {
						Camera.main.gameObject.transform.position =new Vector3 (727,470,991);
						
					}
				}
			}
		}
	
	
	
	
	
	
	}
}
