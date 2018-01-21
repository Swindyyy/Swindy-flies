using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class CanLoadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        String dataPath = Application.persistentDataPath + "/playerInfo.di";
        if (File.Exists(dataPath) == false)
        {
            Button load = transform.GetComponent<Button>();
            load.interactable = false;
        }
        
	}
	
	
}
