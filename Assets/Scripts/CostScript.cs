using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CostScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Text costText = GetComponent<Text>();
	    if(transform.parent.name == "Launch")
        {
            costText.text = "Cost: " + PlayerData.playerInfo.launchCost.ToString();
        }
        if (transform.parent.name == "Red")
        {
            costText.text = "Cost: " + PlayerData.playerInfo.redCost.ToString();
        }
        if (transform.parent.name == "Blue")
        {
            costText.text = "Cost: " + PlayerData.playerInfo.blueCost.ToString();
        }
        if (transform.parent.name == "Green")
        {
            costText.text = "Cost: " + PlayerData.playerInfo.greenCost.ToString();
        }
	}
}
