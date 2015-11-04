using UnityEngine;
using System.Collections;

public class CharacterWalk : MonoBehaviour
{
    public float moveSpeed;
	public float cameraspeed;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Mouse X");

        transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * moveSpeed);
		transform.Rotate(new Vector3(0, x, 0) * Time.deltaTime * cameraspeed);
    }


}