using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnglePivot : MonoBehaviour {

    public Image needle;
    private bool increasing;
    private Transform needleRect;
    bool active = true;

	// Use this for initialization
	void Start () {
        needleRect = needle.GetComponent<Transform>();
        increasing = true; 
	}
	
	// Update is called once per frame
	void Update () {
        if (active == true)
        {
            if (increasing == true)
            {
                needleRect.Rotate(0, 0, 1);
            }
            else if (increasing == false)
            {
                needleRect.Rotate(0, 0, -1);
            }

            if (needleRect.transform.rotation.z >= 0.707)
            {
                increasing = false;
            }
            else if (needleRect.transform.rotation.z <= 0)
            {
                increasing = true;
            }
        }        
	}

    public void pauseAnim()
    {
        active = false;
    }     

    public float getRotation()
    {
        return needleRect.transform.rotation.z;
    }
}
