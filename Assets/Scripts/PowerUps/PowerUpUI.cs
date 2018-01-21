using UnityEngine;
using System.Collections;

public class PowerUpUI : MonoBehaviour {

    public bool showUI = false;
    public Canvas uiCanvas;

    public void ShowUI(bool currentUI)
    {
        showUI = currentUI;
        if (showUI == true)
        {
            Time.timeScale = 0f;
            uiCanvas.enabled = true;
        }
        else
        {
            Time.timeScale = 1f;
            uiCanvas.enabled = false;
        }
    }
}
