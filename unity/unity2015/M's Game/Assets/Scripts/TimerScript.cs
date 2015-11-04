using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

	public TuerTimer script;
	public float timer;
	public float timeLeft;
	public bool timerAn = false;
		
	void OnTriggerEnter (Collider spieler) {
				
		if (spieler.gameObject.tag == "Player") {
			Debug.Log ("Trigger");
			if (script.doorOpen == true) {
				script.doorOpen = false;
				timerAn = false;
				timeLeft = timer;
			}
			
		}
	}
	void Update () {
		if (timerAn == false) 
			timeLeft -= Time.deltaTime ;
		if (timeLeft <= 0) {
			script.doorOpen = true;
			timerAn = true;
			timeLeft = 0;
		}
	}
}