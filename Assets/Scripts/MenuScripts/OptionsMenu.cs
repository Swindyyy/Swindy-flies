using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

    public GameObject options;
    public GameObject menu;
    public Slider musicSlider;
    public Slider sfxSlider;
    public Toggle musicToggle;
    public Toggle sfxToggle;

    void Start()
    {
        musicSlider = musicSlider.GetComponent<Slider>();
        sfxSlider = sfxSlider.GetComponent<Slider>();
        musicToggle = musicToggle.GetComponent<Toggle>();
        sfxToggle = sfxToggle.GetComponent<Toggle>();
    }
    public void Enable()
    {
        options.SetActive(true);
        menu.SetActive(false);
    }
    
    public void Disable()
    {
        menu.SetActive(true);
        options.SetActive(false);
        
    }

    public void SaveMusicSettings()
    {
        PlayerPrefs.SetFloat("musicSlider", musicSlider.value);
        if(musicToggle.isOn)
        {
            PlayerPrefs.SetInt("musicToggle", 1);
        }
        else
        {
            PlayerPrefs.SetInt("musicToggle", 0);
        }

    }

    public void SaveSfxSettings()
    {
        PlayerPrefs.SetFloat("sfxSlider", sfxSlider.value);
        if (sfxToggle.isOn)
        {
            PlayerPrefs.SetInt("sfxToggle", 1);
        }
        else
        {
            PlayerPrefs.SetInt("sfxToggle", 0);
        }
    }
}
