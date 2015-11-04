using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public int coins = 0;
	private GameObject coin;
	
	void OnTriggerEnter (Collider other) {

		if (other.tag == "Coin") {
				coins += 1;
				Destroy(other.gameObject);
			GameObject.Find ("GameManager").GetComponent<ManagerScript>().Punkte+=100;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
