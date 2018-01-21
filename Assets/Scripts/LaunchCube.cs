using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LaunchCube : MonoBehaviour {

	public GameObject angleObject;
	public GameObject powerObject;
    public GameObject manager;


	public float angle;
	public float power;
	public bool launched;

    float launchMultiplier;

	// Use this for initialization
	void Start () {

        manager = GameObject.FindGameObjectWithTag("Manager");
        launchMultiplier = manager.GetComponent<PlayerData>().GetLaunchPoints();
		ChangeAngle angleScript = (ChangeAngle)angleObject.GetComponent (typeof(ChangeAngle));
		angle = angleScript.GetAngle ();
		ChangeNumber powerScript = (ChangeNumber)powerObject.GetComponent (typeof(ChangeNumber));
		power = powerScript.GetPower ();
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		launched = false;
	
	}

    void Update()
    {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		if (launched == false) {
			Debug.Log ("launch");
			GetComponent<Rigidbody2D> ().AddForce (transform.right * power * 20f * launchMultiplier);
			GetComponent<Rigidbody2D>().gravityScale = 0.2f;
            GetComponent<Boost>().enabled = true;
			launched = true;
            
		}
	}

}
