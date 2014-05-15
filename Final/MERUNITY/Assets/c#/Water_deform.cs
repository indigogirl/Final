using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Water_deform : MonoBehaviour {

	//store the original position of each vertex
	List<Vector3> baseVertices = new List<Vector3>();

	//reserve some memory for deforming the vertices
	List<Vector3> workingCopy = new List<Vector3>();

	// Use this for initialization
	void Start () {
	//remember where all the vertices started
		baseVertices = new List<Vector3> (GetComponent<MeshFilter> ().mesh.vertices);
		workingCopy = new List<Vector3> (baseVertices);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<workingCopy.Count; i++) {

						//apply the sin wave to make it bouncy!
						workingCopy[i] = baseVertices [i]
										+ Vector3.up 
										* Mathf.Sin (Time.time + i) *0.12f;
	
				}

				GetComponent<MeshFilter> ().mesh.vertices = workingCopy.ToArray ();

		//spits data into physics, so rigid body will react (without this line, it is just visual)
		GetComponent<MeshCollider> ().sharedMesh = GetComponent<MeshFilter> ().mesh;
		//recalculate normals for correct shading
		GetComponent<MeshFilter>().mesh.RecalculateNormals ();
		}
}
