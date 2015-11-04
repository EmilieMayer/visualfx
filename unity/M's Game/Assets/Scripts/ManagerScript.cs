using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerScript : MonoBehaviour {

	public Text Punktestand;
	public int Punkte;
	public static ManagerScript instance;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void OnGUI () {
		Punktestand.text = Punkte.ToString ();
	}

	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
				Destroy(gameObject);
			}
}
}