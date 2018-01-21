using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boost : MonoBehaviour {

    public Text boostUI;
    float cooldown;
    float currentCD;
    int power;
    bool usable;

	// Use this for initialization
	void Start () {
        cooldown = PlayerData.playerInfo.boostCooldown;
        usable = true;
        power = PlayerData.playerInfo.boostPower;
       
	}
	
	// Update is called once per frame
	void Update () {
	    if(usable == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(500f + (power * 50f), 200f + (power * 50f)));
                currentCD = cooldown;
                usable = false;
            }
        }
        if(currentCD > 0f)
        {
            currentCD -= Time.deltaTime;
            boostUI.text = "Boost: " + (int)currentCD;
        }
        if(currentCD <= 0f)
        {
            usable = true;
            boostUI.text = "Boost: Ready";
        }
	}
}
