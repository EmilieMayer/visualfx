using UnityEngine;
using System.Collections;

public class LeiterScript : MonoBehaviour {

	public float climbSpeed;
	
	void OnTriggerStay (Collider other) {

		if (other.gameObject.tag == "Leiter") 
		{

			if (Input.GetMouseButton (0))
			{
				transform.Translate (Vector3.up * Time.deltaTime * climbSpeed);
			}
		}
	}
	

}