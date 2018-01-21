using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour
{

    public GameObject Player;
    Rigidbody2D PlayerRB;
    float speed;
    float pos = 0;

    // Use this for initialization
    void Start()
    {
        if (Player != null)
        {
            PlayerRB = Player.GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector3 playerPos = Player.transform.position;
            speed = PlayerRB.velocity.x;
            pos = Mathf.Repeat(Time.time * speed, 1);

            GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", new Vector2(pos * 0.05f, 0));
            transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
        }
    }
}
