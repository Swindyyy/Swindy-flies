using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloorCollision : MonoBehaviour {

    public GameObject endUI;
    public GameObject midUI;

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.transform.tag == "Floor")
        {
            EndGame(col);
            GiveCoins();
            col.transform.GetComponent<Collider2D>().enabled = false;
            
        }
    }


    void EndGame(Collision2D col)
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
        midUI.SetActive(false);
        endUI.SetActive(true);
        Text endDistance = GameObject.Find("DistanceText").GetComponent<Text>();
        GameObject manager = GameObject.FindWithTag("PlayerManager");
        ManagerScript script = manager.GetComponent<ManagerScript>();
        endDistance.text = script.totalDistance.ToString();
        GetComponentInChildren<SpawnPowerUps>().enabled = false;
    }

    void GiveCoins()
    {
        GameObject manager = GameObject.FindWithTag("PlayerManager");
        ManagerScript script = manager.GetComponent<ManagerScript>();
        Text coinText = GameObject.Find("CoinText").GetComponent<Text>();
        float distance = script.totalDistance;
        int coins = (int)distance/2;
        coinText.text = "+" + coins.ToString() + " coins";
        PlayerData.playerInfo.ChangeCoins(coins);
        GameControl.control.Save();
        Debug.Log("Coins");
    }
}
