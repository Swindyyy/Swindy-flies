using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game {

    public static Game current;
    public int redPoints;
    public int bluePoints;
    public int greenPoints;
    public int launchPoints;
    

    public Game()
    {
        
    }

    public void setPoints(string powerUp, int points)
    {
        string tempPowerUp = powerUp.ToUpper();
        if(tempPowerUp == "RED")
        {
            redPoints = points;
        }
        if(tempPowerUp == "BLUE")
        {
            bluePoints = points;
        }
    }
}
