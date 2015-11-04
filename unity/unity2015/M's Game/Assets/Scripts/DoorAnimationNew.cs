using UnityEngine;
using System.Collections;

public class DoorAnimationNew : MonoBehaviour {

	 private Animation anima;

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		anima = this.gameObject.GetComponent<Animation> ();
		anima.Play ("opennew");
	
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider other) {
		anima = this.gameObject.GetComponent<Animation> ();
		anima.Play ("closenew");
	}
}
