using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    GameObject manager;
    PlayerData script;
    int multiplier;

	// Use this for initialization
	void Start () {
        manager = GameObject.FindWithTag("Manager");
        script = manager.GetComponent<PlayerData>();
        if (this.tag == "BigPowerUp")
        {
            multiplier = script.redPowerUpPoints;
        }
        if (this.tag == "MediumPowerUp")
        {
            multiplier = script.bluePowerUpPoints;
        }
        if (this.tag == "SmallPowerUp")
        {
            multiplier = script.greenPowerUpPoints;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
            col.rigidbody.AddForce(new Vector2(500f + (multiplier * 50f), 200f + (multiplier * 50f)));
			Destroy(gameObject);
		}
	}
}
