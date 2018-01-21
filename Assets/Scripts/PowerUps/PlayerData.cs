using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerData : MonoBehaviour {

    public static PlayerData playerInfo;
    public int redPowerUpPoints;
    public int bluePowerUpPoints;
    public int greenPowerUpPoints;
    public int launchPowerUpPoints;
    public int coins;
    public float boostCooldown;
    public int boostPower;

    public bool paid;
    public int redCost;
    public int blueCost;
    public int greenCost;
    public int launchCost;


	// Use this for initialization
	void Start () {


        playerInfo = this;
        redPowerUpPoints = 1;
        bluePowerUpPoints = 1;
        greenPowerUpPoints = 1;
        launchPowerUpPoints = 1;
        boostCooldown = 30;
        coins = 0;
        redCost = 250;
        blueCost = 250;
        greenCost = 250;
        launchCost = 250;
       
        
	}
	
	

    public void AddPoint(string powerUp)
    {
        string capsPowerUp = powerUp.ToUpper();
        if (capsPowerUp == "RED")
        {
            if (coins >= redCost)
            {
                redPowerUpPoints += 1;
                coins -= redCost;
                redCost = redCost * 2;
            }
            else
            {
                Debug.Log("Not enough coins");
            }
        }
        else if (capsPowerUp == "BLUE")
        {
            if (coins >= blueCost)
            {
                bluePowerUpPoints += 1;
                coins -= blueCost;
                blueCost = blueCost * 2;
            }
            else
            {
                Debug.Log("Not enough coins");
            }
        }
        else if (capsPowerUp == "GREEN")
        {
            if (coins >= greenCost)
            {
                greenPowerUpPoints += 1;
                coins -= greenCost;
                greenCost = greenCost * 2;
            }
            else
            {
                Debug.Log("Not enough coins");
            }
        }
        else if (capsPowerUp == "LAUNCH")
        {
            if (coins >= launchCost)
            {
                launchPowerUpPoints += 1;
                coins -= launchCost;
                launchCost = launchCost * 2;
            }
            else
            {
                Debug.Log("Not enough coins");
            }
        }

    }

    public void ChangeCoins(int change)
    {
        coins += change;
        paid = true;
    }

    public float GetLaunchPoints()
    {
        return launchPowerUpPoints;
    }

   
}
