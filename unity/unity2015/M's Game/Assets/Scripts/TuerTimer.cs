using UnityEngine;
using System.Collections;

public class TuerTimer : MonoBehaviour {
	
	public bool doorOpen = false;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (doorOpen == true) {
			GetComponent<MeshRenderer> ().enabled = true;
			GetComponent<MeshCollider> ().enabled = true;
			GetComponent<BoxCollider> ().enabled = true;
		} else {
			GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<MeshCollider> ().enabled = false;
			GetComponent<BoxCollider> ().enabled = false;
		}
		
	}
}
