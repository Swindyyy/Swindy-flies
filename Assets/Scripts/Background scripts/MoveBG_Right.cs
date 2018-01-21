using UnityEngine;
using System.Collections;

public class MoveBG_Right : MonoBehaviour {

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
            float heightOfBgObject = col.GetComponent<BoxCollider2D>().size.x;
            Vector3 pos = col.transform.position;
            pos.x += (heightOfBgObject * numBgPanels);
            col.transform.position = pos;
           // R1C1.transform.position = new Vector3(pos.x, R1C1.transform.position.y, R1C1.transform.position.z);
            //R1C2.transform.position = new Vector3(pos.x, R1C2.transform.position.y, R1C2.transform.position.z);
            //R1C3.transform.position = new Vector3(pos.x, R1C3.transform.position.y, R1C3.transform.position.z);
            //R1C4.transform.position = new Vector3(pos.x, R1C4.transform.position.y, R1C4.transform.position.z);
        }

        if (col.tag == "BackgroundTileMiddle")
        {
            float heightOfBgObject = col.GetComponent<BoxCollider2D>().size.x;
            Vector3 pos = col.transform.position;
            pos.x += (heightOfBgObject * numBgPanels);
            col.transform.position = pos;
            //R2C1.transform.position = new Vector3(pos.x, R2C1.transform.position.y, R2C1.transform.position.z);
            //R2C2.transform.position = new Vector3(pos.x, R2C2.transform.position.y, R2C2.transform.position.z);
            //R2C3.transform.position = new Vector3(pos.x, R2C3.transform.position.y, R2C3.transform.position.z);
            //R2C4.transform.position = new Vector3(pos.x, R2C4.transform.position.y, R2C4.transform.position.z);
        }

        if (col.tag == "BackgroundTileTop")
        {
            float heightOfBgObject = col.GetComponent<BoxCollider2D>().size.x;
            Vector3 pos = col.transform.position;
            pos.x += (heightOfBgObject * numBgPanels);
            col.transform.position = pos;
            //R3C1.transform.position = new Vector3(pos.x, R3C1.transform.position.y, R3C1.transform.position.z);
            //R3C2.transform.position = new Vector3(pos.x, R3C2.transform.position.y, R3C2.transform.position.z);
            //R3C3.transform.position = new Vector3(pos.x, R3C3.transform.position.y, R3C3.transform.position.z);
            //R3C4.transform.position = new Vector3(pos.x, R3C4.transform.position.y, R3C4.transform.position.z);
        }
    }
    
 }
