using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {

	public Vector2 Force;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		Force.x = 50f;
		Force.y = 15f;
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (Force);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetMouseButton (0)) {
			rb.AddForce(Force);

		}
	}
}
