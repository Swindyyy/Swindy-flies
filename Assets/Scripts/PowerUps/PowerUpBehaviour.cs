using UnityEngine;
using System.Collections;

public class PowerUpBehaviour : MonoBehaviour {

    Vector3 ScrBnd;
    Vector3 BotLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ScrBnd = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        BotLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        //Debug.Log(transform.position.y + "," + (BotLeft.y * 1.1f));
        if (transform.position.x < BotLeft.x * 0.99f)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > (ScrBnd.y * 1.2f))
        {
            Destroy(gameObject);
        }
        if(transform.position.y > BotLeft.y * 2f)
        {
            Destroy(gameObject);
        }
	}
}
    
