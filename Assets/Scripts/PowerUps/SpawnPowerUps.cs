using UnityEngine;
using System.Collections;


public class SpawnPowerUps : MonoBehaviour {

    public GameObject SmallBoost;
    public GameObject mediumBoost;
    public GameObject bigBoost;

    float SpawnGenNum;
    float SpawnTimer;
    float prevPosition;
    Vector3 ScrBnd;
    Vector3 BotLeft;

	// Use this for initialization
	void Start () {
        ScrBnd = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        BotLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
	}
	
	// Update is called once per frame
    void Update()
    {
        //Debug.Log(SpawnTimer);
        SpawnTimer += Time.deltaTime;
        ScrBnd = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        BotLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));

        if (SpawnTimer > 0.5f)
        {
            SpawnGenNum = SpawningGenerator();
            if (SpawnGenNum > 90f)
            {
                SpawnPowerUp(bigBoost);
            }
            if (SpawnGenNum > 50f && SpawnGenNum < 90f)
            {
                SpawnPowerUp(mediumBoost);
            }
            if (SpawnGenNum > 0f && SpawnGenNum < 50f)
            {
                SpawnPowerUp(SmallBoost);
            }
            SpawnTimer = 0f;
        }
        prevPosition = transform.parent.position.y;
    }
        

	

    void SpawnPowerUp(GameObject powerUp)
    {
        //Debug.Log("Spawn");
        Rigidbody2D rbody = transform.parent.GetComponent<Rigidbody2D>();
        if(transform.parent.position.y > prevPosition)
        {
            Vector3 spawnPos = new Vector3(Random.Range(ScrBnd.x, ScrBnd.x * 1.1f * rbody.velocity.x), Random.Range(BotLeft.y, (ScrBnd.y * 1.3f)), 0);
            Instantiate(powerUp, spawnPos, Quaternion.identity);
        }
        else if (transform.parent.position.y < prevPosition)
        {
            Vector3 spawnPos = new Vector3(Random.Range(ScrBnd.x, ScrBnd.x * 1.1f * rbody.velocity.x), Random.Range(-ScrBnd.y * 0.5f, BotLeft.y), 0);
            Instantiate(powerUp, spawnPos, Quaternion.identity);
        }
        
       
        
    }

    float SpawningGenerator()
    {
        float x = Random.Range(0f, 100f);
        return x;
    }
}
