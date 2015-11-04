using UnityEngine;
using System.Collections;

public class KraftfeldScript : MonoBehaviour {

	public bool fieldOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (fieldOn == true) {
			GetComponent<BoxCollider> ().enabled = true;
			GetComponent<ParticleSystem> ().enableEmission = true;
			GetComponent<AudioSource> ().enabled = true;

		} else {
			GetComponent<BoxCollider> ().enabled = false;
			GetComponent<ParticleSystem> ().enableEmission = false;
			GetComponent<AudioSource> ().enabled = false;
		}
	
	}
}
