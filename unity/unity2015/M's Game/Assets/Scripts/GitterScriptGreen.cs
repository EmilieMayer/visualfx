using UnityEngine;
using System.Collections;
public class GitterScriptGreen : MonoBehaviour {
	
	
	void Start () {
		
	}
	
	void OnTriggerEnter (Collider col) {
		
		GameObject GameManager = GameObject.FindGameObjectWithTag("GameManager"); 
		ManagerScript Script = GameManager.GetComponent<ManagerScript>();
		
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Erkennt");
			for( var i = 0; i < Script.inventory.Count; i++ ){
				var currentItem = Script.inventory[i];
				if(currentItem != null){
					if (currentItem.tag == "Green") {
						Debug.Log (currentItem.name);
						gameObject.SetActive(false);
						Script.inventory.Remove (currentItem);
						
					}
				}
			}
		}
	}
}