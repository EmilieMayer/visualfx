using UnityEngine;
using System.Collections;

public class Level2Script : MonoBehaviour {
	private GameObject Spielfigur;
	
	
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel ("Level1");
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
