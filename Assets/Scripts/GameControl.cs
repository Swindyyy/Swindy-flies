using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

    public static GameControl control;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(this);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        String dataPath = Application.persistentDataPath + "/playerInfo.di";
        FileStream file;
        if (File.Exists(dataPath))
        {
            file = File.Open(dataPath, FileMode.Open);
        }
        else
        {
            file = File.Create(dataPath);
        }
        GameObject manager = GameObject.FindWithTag("Manager");
        PlayerData info = manager.GetComponent<PlayerData>();
        Data data = new Data();
        data.redPowerUpPoints = info.redPowerUpPoints;
        data.bluePowerUpPoints = info.bluePowerUpPoints;
        data.greenPowerUpPoints = info.greenPowerUpPoints;
        data.launchPowerUpPoints = info.launchPowerUpPoints;
        data.coins = info.coins;

        bf.Serialize(file, data);
        file.Close();


    }
	
    public void Load()
    {
        GameObject manager = GameObject.FindWithTag("Manager");
        PlayerData info = manager.GetComponent<PlayerData>();
        String dataPath = Application.persistentDataPath + "/playerInfo.di";
        if(File.Exists(dataPath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(dataPath, FileMode.Open);
            Data data = (Data)bf.Deserialize(file);
            file.Close();
            info.redPowerUpPoints = data.redPowerUpPoints;
            info.bluePowerUpPoints = data.bluePowerUpPoints;
            info.greenPowerUpPoints = data.greenPowerUpPoints;
            info.launchPowerUpPoints = data.launchPowerUpPoints;
            info.coins = data.coins;
        }
    }
}

[Serializable]
class Data
{
    public int redPowerUpPoints;
    public int bluePowerUpPoints;
    public int greenPowerUpPoints;
    public int launchPowerUpPoints;
    public int coins;
}
