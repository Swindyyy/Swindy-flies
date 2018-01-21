using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour {

	public GameObject angle;
    public GameObject angleNeedle;
	public GameObject cube;
    public GameObject power;
    public GameObject launchUI;
    public GameObject gameUI;
    public GameObject endUI;
    public GameObject gameWonUI;

	public bool speedDone;
	public bool angleDone;

    public float totalDistance;

	// Use this for initialization
	void Start () {
		angleDone = false;	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = cube.GetComponent<Rigidbody2D>().velocity.x * Time.deltaTime;
        Text distanceText = gameUI.GetComponentInChildren<Text>();
        totalDistance += distance;
        distanceText.text = "Distance: " + totalDistance;
        //Debug.Log(totalDistance);
	}

	public void SetSpeedDone(){
		speedDone = true;
	}

    public void PauseAngleAnim()
    { 
        angleNeedle.GetComponent<AnglePivot>().pauseAnim();
    }

    public void EnableAngle(){
		angle.GetComponent<ChangeAngle>().enabled = true; 
	}

    public void EnableSpeed()
    {
        power.GetComponent<ChangeNumber>().enabled = true;
        power.GetComponentInChildren<powerBar>().startAnim();
    }

    public void EnableLaunch(){
		cube.GetComponent<LaunchCube> ().enabled = true;
        GetComponent<SpawnPowerUps>().enabled = true;
        launchUI.SetActive(false);
        gameUI.SetActive(true);
	}

    public void PauseLaunch(bool input)
    {
        //power.GetComponent<ChangeNumber>().PauseScript(input);
        //angle.GetComponent<ChangeAngle>().PauseScript(input);
    }
}
