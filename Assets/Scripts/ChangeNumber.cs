using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeNumber : MonoBehaviour {

	public float powerFloat;
	public GameObject manager;
    public GameObject powerBar;

    powerBar powerBarScript;
	bool up;
    bool clicked;
    float localTime;
  
    public bool paused;
    float time;

	// Use this for initialization
	void Start () {
		powerFloat = 0f;
		up = true;
		clicked = false;
        localTime = 0f;
        paused = true;
        powerBarScript = powerBar.GetComponent<powerBar>();		   

	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 1f)
        {
            if (localTime > 0.2f)
            {
                paused = false;
            }
            else
            {
                localTime += Time.deltaTime;
            }

            if (paused == false)
            {
                if (Input.GetMouseButton(0) == true && clicked == false)
                {
                    clicked = true;
                    ManagerScript bob = (ManagerScript)manager.GetComponent(typeof(ManagerScript));
                    bob.SetSpeedDone();
                    powerBarScript.pauseAnim();
                    powerFloat = powerBarScript.getSpeed();
                    bob.EnableLaunch();
                }
            }
        }
	}

	public float GetPower(){
		return powerFloat * 50f;
	}

    public void PauseScript(bool input)
    {
        paused = input;
    }
}
