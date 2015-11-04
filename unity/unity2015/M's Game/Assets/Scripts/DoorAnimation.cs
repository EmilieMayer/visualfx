using UnityEngine;
using System.Collections;

public class DoorAnimation : MonoBehaviour {

	 private Animation animation;

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		animation = GetComponent<Animation> ();
		animation.Play ("open");
	
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider other) {
		animation = GetComponent<Animation> ();
		animation.Play ("close");
	}
}
