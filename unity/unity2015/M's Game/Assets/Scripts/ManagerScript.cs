using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ManagerScript : MonoBehaviour {

	public Text Punktestand;
	public int Punkte;
	public static ManagerScript instance;
	public Text Inventar;
	private GameObject PunktestandText;
	private GameObject InventarText;
	public List<GameObject> inventory = new List<GameObject>();
	private string output;


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);

	}
	
	// Update is called once per frame
	void OnGUI () {
		Punktestand.text = Punkte.ToString ();

		Inventar.text = "Inventar: \n";
		foreach (GameObject item in inventory) {
			Inventar.text += item.name + "\n";
		}
	}

	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
				Destroy(gameObject);
			}
}


}