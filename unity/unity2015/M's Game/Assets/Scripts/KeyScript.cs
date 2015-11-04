using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyScript : MonoBehaviour {
	public ManagerScript script;
	void Awake ()
	{
		
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void OnTriggerEnter (Collider Colli ) {
		
		if (Colli.gameObject.tag == "Player")
		{
			GameObject GameManager = GameObject.FindGameObjectWithTag ("GameManager");
			ManagerScript script = GameManager.GetComponent<ManagerScript> ();
			script.inventory.Add (gameObject);
			gameObject.SetActive(false);
		}
	}
	
}
