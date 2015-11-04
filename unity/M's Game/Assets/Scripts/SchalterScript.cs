using UnityEngine;
using System.Collections;

public class SchalterScript : MonoBehaviour {

	public bool doorOpen;
	public DoorScript script;



	void OnMouseDown () {
		if (script.doorOpen == false) {
			script.doorOpen = true;

		} else {
			script.doorOpen = false;
		
		}
	

	}
}
