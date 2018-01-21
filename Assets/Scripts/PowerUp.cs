using UnityEngine;
using System.Collections;

public class PowerUpClass {

    public int currentLevel;
    public int level2Cost;
    public int level3Cost;
    public int level4Cost;
    public int level5Cost;

    public PowerUpClass()
    {
        currentLevel = 1;
        level2Cost = 150;
        level3Cost = 250;
        level4Cost = 500;
        level5Cost = 1000;
    }
}
