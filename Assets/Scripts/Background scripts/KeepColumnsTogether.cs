using UnityEngine;
using System.Collections;

public class KeepColumnsTogether : MonoBehaviour {
    
    public GameObject top;
    public GameObject bottom;

    
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        top.transform.position = new Vector3(pos.x,top.transform.position.y,top.transform.position.z);
        bottom.transform.position = new Vector3(pos.x,bottom.transform.position.y,bottom.transform.position.z);
	}
}
