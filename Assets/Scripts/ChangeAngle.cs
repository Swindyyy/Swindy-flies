using UnityEngine;
using System.Collections;

public class ChangeAngle : MonoBehaviour {

	public GameObject manager;
	public float angleInt;
	private float localTime;
	public bool paused;
	private bool up;
	private bool clicked;



	// Use this for initialization
	void Start () {
		angleInt = 5;
		localTime = 0;
		up = true;
		paused = false;
		clicked = false;
        
	}
	
	// Update is called once per frame
	void Update () {
        
            if (clicked == false)
            {
                if (angleInt < 90f && up == true)
                {
                    angleInt++;
                }
                if (angleInt > 0f && up == false)
                {
                    angleInt--;
                    
                }
                if (angleInt == 85f)
                {
                    up = false;
                }
                if (angleInt == 5f)
                {
                    up = true;
                }
            }
            if (localTime > 0.2f)
            {
                paused = true;
            }
            else
            {
                localTime += Time.deltaTime;
            }
            if (paused == true)
            {
                if (Input.GetMouseButton(0) == true && clicked == false)
                {
                    clicked = true;
                    Debug.Log("Click");
                    ManagerScript bob = (ManagerScript)manager.GetComponent(typeof(ManagerScript));
                    bob.PauseAngleAnim ();
                    bob.EnableSpeed();                 
                }
            }
	}

	public float GetAngle(){
		return angleInt;
	}

    public void PauseScript(bool input) 
    {
        paused = input;
    }
}
