using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangePointsSprite : MonoBehaviour
{

    public GameObject manager;


    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;

    PlayerData mainScript;
    Image powerUp;

    // Use this for initialization
    void Start()
    {

        powerUp = transform.GetComponent<Image>();
        mainScript = PlayerData.playerInfo;
        
    }

    // Update is called once per frame
    void Update()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        if (transform.parent.name == "Red")
        {
            if (mainScript.redPowerUpPoints == 1)
            {

                powerUp.sprite = one;

            }
            if (mainScript.redPowerUpPoints == 2)
            {
                powerUp.sprite = two;
                
            }
            if (mainScript.redPowerUpPoints == 3)
            {
                powerUp.sprite = three;

            }
            if (mainScript.redPowerUpPoints == 4)
            {
                powerUp.sprite = four;

                
            }
            if (mainScript.redPowerUpPoints == 5)
            {
                powerUp.sprite = five;
                Button powerUpButton = transform.parent.GetComponentInChildren<Button>();
                Text buttonText = powerUpButton.GetComponentInChildren<Text>();
                powerUpButton.interactable = false;
                buttonText.text = "Max rank";
            }
        }
        if (transform.parent.name == "Blue")
        {
            if (mainScript.bluePowerUpPoints == 1)
            {
                powerUp.sprite = one;
            }
            if (mainScript.bluePowerUpPoints == 2)
            {
                powerUp.sprite = two;

            }
            if (mainScript.bluePowerUpPoints == 3)
            {
                powerUp.sprite = three;

            }
            if (mainScript.bluePowerUpPoints == 4)
            {
                powerUp.sprite = four;
            }
            if (mainScript.bluePowerUpPoints == 5)
            {
                powerUp.sprite = five;
                Button powerUpButton = transform.parent.GetComponentInChildren<Button>();
                Text buttonText = powerUpButton.GetComponentInChildren<Text>();
                powerUpButton.interactable = false;
                buttonText.text = "Max rank";
            }
        }
        if (transform.parent.name == "Green")
        {
            if (mainScript.greenPowerUpPoints == 1)
            {
                powerUp.sprite = one;
            }
            if (mainScript.greenPowerUpPoints == 2)
            {
                powerUp.sprite = two;
            }
            if (mainScript.greenPowerUpPoints == 3)
            {
                powerUp.sprite = three;                
            }
            if (mainScript.greenPowerUpPoints == 4)
            {
                powerUp.sprite = four;
            }
            if (mainScript.greenPowerUpPoints == 5)
            {
                powerUp.sprite = five;
                Button powerUpButton = transform.parent.GetComponentInChildren<Button>();
                Text buttonText = powerUpButton.GetComponentInChildren<Text>();
                powerUpButton.interactable = false;
                buttonText.text = "Max rank";
            }
        }
        if (transform.parent.name == "Launch")
        {
            if (mainScript.launchPowerUpPoints == 1)
            {
                powerUp.sprite = one;
            }
            if (mainScript.launchPowerUpPoints == 2)
            {
                powerUp.sprite = two;
                
            }
            if (mainScript.launchPowerUpPoints == 3)
            {
                powerUp.sprite = three;
            }
            if (mainScript.launchPowerUpPoints == 4)
            {
                powerUp.sprite = four;
            }
            if (mainScript.launchPowerUpPoints == 5)
            {
                powerUp.sprite = five;
                Button powerUpButton = transform.parent.GetComponentInChildren<Button>();
                Text buttonText = powerUpButton.GetComponentInChildren<Text>();
                powerUpButton.interactable = false;
                buttonText.text = "Max rank";
            }
        }
    }
}

