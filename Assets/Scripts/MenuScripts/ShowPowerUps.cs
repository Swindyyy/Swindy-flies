using UnityEngine;
using System.Collections;

public class ShowPowerUps : MonoBehaviour {

    public GameObject powerUpUI;
    public GameObject endUI;

	public void On()
    {
        powerUpUI.SetActive(true);
        endUI.SetActive(false);
    }
    
    public void Off()
    {
        endUI.SetActive(true);
        powerUpUI.SetActive(false);
    }
}
