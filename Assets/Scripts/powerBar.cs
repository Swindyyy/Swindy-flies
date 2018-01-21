using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class powerBar : MonoBehaviour {

    public Image bar;
    private bool increasing = true;
    private bool active = false;

    void Start()
    {
        bar.fillAmount = 0f;
    }
	// Update is called once per frame
	void Update () {
        if (active == true)
        {
            if (increasing == true)
            {
                bar.fillAmount += Time.deltaTime;
            }
            else if (increasing == false)
            {
                bar.fillAmount -= Time.deltaTime;
            }

            if (bar.fillAmount == 1)
            {
                increasing = false;
            }
            else if (bar.fillAmount == 0)
            {
                increasing = true;
            }
        }
	}

    public void pauseAnim()
    {
        active = false;
    }

    public void startAnim()
    {
        active = true;
    }

    public float getSpeed()
    {
        return bar.fillAmount;
    }

}
