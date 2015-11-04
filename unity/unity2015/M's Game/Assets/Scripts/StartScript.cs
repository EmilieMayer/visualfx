using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	public Transform Ziel;
	
	void OnCollisionEnter (Collision other) {
		GameObject Spielfigur = GameObject.FindWithTag ("Player");
		Spielfigur.GetComponent<Transform> ();
		Spielfigur.transform.position = new Vector3 (this.Ziel.position.x, this.Ziel.position.y, this.Ziel.position.z);
		Spielfigur.transform.rotation = Quaternion.identity;

		AudioSource Beam = GetComponent<AudioSource> ();
		Beam.Play ();
	}
}
