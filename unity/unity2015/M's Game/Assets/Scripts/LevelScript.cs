using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {
	private GameObject Spielfigur;


	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel ("Level2");
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
