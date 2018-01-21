using UnityEngine;
using System.Collections;

public class MoveCubeKeys : MonoBehaviour {

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(new Vector2(5f*Input.GetAxis("Horizontal"),0));
        rb.AddForce(new Vector2(0, 5f * Input.GetAxis("Vertical")));
	}
}
