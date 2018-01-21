using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
    public GameObject cube;
    public static CameraFollow camFollow; 

    Vector3 cubePos;
    
    Vector3 camPosGame;
    

	
	// Update is called once per frame
	void Update () {
        cubePos = cube.transform.position;
        
        camPosGame = new Vector3(cubePos.x + 6.25f, cubePos.y + 0.05f, -10f);
		
        transform.position = camPosGame;
        
        
       
	}

}
