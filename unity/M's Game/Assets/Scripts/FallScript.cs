using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {

	RaycastHit hit;
	public float maxFallingDistance = 2f;
	public float fallhoehe;
	public float fallingDistance;
	public bool willDie = false;

	void OnCollisionEnter (Collision other) {
		fallingDistance = 0;
	}
	
	void FixedUpdate(){
		if (Physics.Raycast(transform.position, Vector3.down, out hit))
		{
			if (hit.distance < fallhoehe) {
				
				fallingDistance += fallhoehe - hit.distance;
				if (fallhoehe >= maxFallingDistance){
					willDie = true;
				}
			}
			else if (fallingDistance > maxFallingDistance) {
				if (willDie == true){
					Application.LoadLevel("Level1");			
				}
			}
			
			fallhoehe = hit.distance;
			
		}
	}
}