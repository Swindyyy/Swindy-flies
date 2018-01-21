using UnityEngine;
using System.Collections;

public class PowerValue : MonoBehaviour {

    public int angle;

	// Use this for initialization
	void Start () {
        angle = 5;
	}
	
    public void SetAngle(int ang)
    {
        angle = ang;
    }
}
