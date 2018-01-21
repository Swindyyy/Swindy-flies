using UnityEngine;
using System.Collections;

public class MoveBG_Down : MonoBehaviour {

    public int numBgPanels;

    public GameObject R1C1;
    public GameObject R1C2;
    public GameObject R1C3;
    public GameObject R1C4;
    public GameObject R2C1;
    public GameObject R2C2;
    public GameObject R2C3;
    public GameObject R2C4;
    public GameObject R3C1;
    public GameObject R3C2;
    public GameObject R3C3;
    public GameObject R3C4;
  
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("collision");
        if (col.tag == "BackgroundTileBottom")
        {
            float heightOfBgObject = col.GetComponent<BoxCollider2D>().size.y;
            Vector3 pos = col.transform.position;
            pos.y -= (heightOfBgObject * numBgPanels);
            R1C1.transform.position = new Vector3(R1C1.transform.position.x,pos.y,0);
            R1C2.transform.position = new Vector3(R1C2.transform.position.x, pos.y, 0);
            R1C3.transform.position = new Vector3(R1C3.transform.position.x, pos.y, 0);
            R1C4.transform.position = new Vector3(R1C4.transform.position.x, pos.y, 0);
        }

        if (col.tag == "BackgroundTileMiddle")
        {
            float heightOfBgObject = col.GetComponent<BoxCollider2D>().size.y;
            Vector3 pos = col.transform.position;
            pos.y -= (heightOfBgObject * numBgPanels);
            R2C1.transform.position = new Vector3(R2C1.transform.position.x, pos.y, 0);
            R2C2.transform.position = new Vector3(R2C2.transform.position.x, pos.y, 0);
            R2C3.transform.position = new Vector3(R2C3.transform.position.x, pos.y, 0);
            R2C4.transform.position = new Vector3(R2C4.transform.position.x, pos.y, 0);
        }

        if (col.tag == "BackgroundTileTop")
        {
            float heightOfBgObject = col.GetComponent<BoxCollider2D>().size.y;
            Vector3 pos = col.transform.position;
            pos.y -= (heightOfBgObject * numBgPanels);
            R3C1.transform.position = new Vector3(R3C1.transform.position.x, pos.y, 0);
            R3C2.transform.position = new Vector3(R3C2.transform.position.x, pos.y, 0);
            R3C3.transform.position = new Vector3(R3C3.transform.position.x, pos.y, 0);
            R3C4.transform.position = new Vector3(R3C4.transform.position.x, pos.y, 0);
        }
    }
}
