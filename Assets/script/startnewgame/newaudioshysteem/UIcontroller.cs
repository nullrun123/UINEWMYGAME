using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    public audioManager AudioManager; 

    private const string MusicVolumeKey = "MusicVolume";
    private const string SFXVolumeKey = "SFXVolume";

    
    void Start()
    {
       
        AudioManager = FindObjectOfType<audioManager>();

        if (PlayerPrefs.HasKey(MusicVolumeKey))
            _musicSlider.value = PlayerPrefs.GetFloat(MusicVolumeKey);
        if (PlayerPrefs.HasKey(SFXVolumeKey))
            _sfxSlider.value = PlayerPrefs.GetFloat(SFXVolumeKey);
    }

    public void ToggleMusic()
    {
        AudioManager.ToggleMusic();
        Debug.Log("ทำงานป่ะ/");
    }

    public void ToggleSFX()
    {
        AudioManager.ToggleSFX();
    }

    public void MusicVolume()
    {
        AudioManager.MusicVolume(_musicSlider.value);
        PlayerPrefs.SetFloat(MusicVolumeKey, _musicSlider.value); 
    }

    public void SFXVolume()
    {
        AudioManager.SFXVolume(_sfxSlider.value);
        PlayerPrefs.SetFloat(SFXVolumeKey, _sfxSlider.value); 
    }
}
