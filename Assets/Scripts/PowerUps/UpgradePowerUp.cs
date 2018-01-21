using UnityEngine;
using System.Collections;

public class UpgradePowerUp : MonoBehaviour {

	public void Upgrade(string word)
    {
        PlayerData.playerInfo.AddPoint(word);
    }
}
