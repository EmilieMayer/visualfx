using UnityEngine;
using System.Collections;

public class BandScript : MonoBehaviour {

	public int strength = 10;
	public Transform gc;
	private GameObject go;
	private Rigidbody rb;
	private Transform pl;

	// Use this for initialization
	void Start () {
		go = GameObject.FindWithTag ("Player");
		rb = go.GetComponent<Rigidbody> ();
		pl = go.GetComponent<Transform> ();
			
	}
	
	// Update is called once per frame
	void OnCollisionStay (Collision band) {
		if (band.gameObject.tag == "Player") {
			Vector3 direction = gc.transform.position - pl.transform.position;
			rb.AddForce(direction.normalized * strength);
		}
	
	}
}
