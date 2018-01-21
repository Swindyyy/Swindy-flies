using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinScript : MonoBehaviour {

    public GameObject manager;

    PlayerData mainScript;


    int coins;
	
  
	// Update is called once per frame
	void Update () {
        coins = PlayerData.playerInfo.coins;
        Text coinText = GetComponentInChildren<Text>();
        coinText.text = coins.ToString();
	}
}
