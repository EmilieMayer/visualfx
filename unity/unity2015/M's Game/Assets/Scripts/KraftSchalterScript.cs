using UnityEngine;
using System.Collections;

public class KraftSchalterScript : MonoBehaviour {
	
	public bool fieldOn;
	public KraftfeldScript script;

	void OnTriggerEnter (Collider spieler) {
		if (spieler.gameObject.tag == "Player") {

			if (script.fieldOn == true) {
				script.fieldOn = false;
			
			} else {
				script.fieldOn = true;
			
			}
		}
		
	}
}
