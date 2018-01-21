using UnityEngine;
using System.Collections;

public class KeepRowColliderInRow : MonoBehaviour {

    public GameObject row;

    BoxCollider2D rowCol;

	// Use this for initialization
	void Start () {
        rowCol = row.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rowCol.transform.position = new Vector3(transform.position.x, transform.position.y, rowCol.transform.position.z);
	}
}
