using UnityEngine;
using System.Collections;

public class TutorialManagerScript : MonoBehaviour {

    public GameObject PowerTut;
    public GameObject AngleTut;
    public GameObject BoostTut;
    public GameObject DistanceTut;
    public GameObject RestartGameTut;
    public GameObject PowerObject;
    public GameObject AngleObject;
    

    bool power;
    bool angle;
    bool boost;
    bool distance;
    bool end;
    float time;

    GameObject PlayerManager;
    GameObject Player;
    Rigidbody2D PlayerRB;
    ManagerScript PManager;
    Vector2 speed;

	// Use this for initialization
	void Start () {
        PlayerManager = GameObject.FindGameObjectWithTag("PlayerManager");
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerRB = Player.GetComponent<Rigidbody2D>();
        PManager = PlayerManager.GetComponent<ManagerScript>();
        power = true;
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(power == true)
        {
            //Debug.Log("test");   
            if(Input.GetMouseButtonUp(0))
            {   
                angle = true;
                DisableGameObject(PowerTut);
                EnableGameObject(AngleTut);
                ChangeNumber powerScript = (ChangeNumber)PowerObject.GetComponent(typeof(ChangeNumber));
                powerScript.powerFloat = 40;
                power = false;
            }
        }

        else if (angle == true)
        {
            //Debug.Log("test");
            if (Input.GetMouseButtonUp(0))
            {

                distance = true;
                DisableGameObject(AngleTut);
                ChangeAngle angleScript = (ChangeAngle)AngleObject.GetComponent(typeof(ChangeAngle));
                angleScript.angleInt = 50;
                Player.GetComponent<Boost>().enabled = false;
                
            }
            if(PManager.totalDistance > 25)
            {
                EnableGameObject(DistanceTut);
                PlayerRB.velocity = new Vector2(0, 0);
                PlayerRB.gravityScale = 0f;
                angle = false;
            }
        }
        else if (boost == true)
        {
            
            if(Input.GetMouseButtonUp(0))
            {
                end = true;
                DisableGameObject(BoostTut);
                EnableGameObject(RestartGameTut);
                
                boost = false;
            }
        }
        else if (distance == true)
        {
            
            if(Input.GetMouseButtonUp(0))
            {
                boost = true;
                DisableGameObject(DistanceTut);
                EnableGameObject(BoostTut);
                distance = false;
             }
        }
        else if (end == true)
        {
             if(Input.GetMouseButtonUp(0))
             {
                 Application.LoadLevel(1);
             }
        }
	}

    void EnableGameObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    void DisableGameObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
