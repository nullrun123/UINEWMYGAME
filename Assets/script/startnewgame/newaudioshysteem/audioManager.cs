using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static audioManager Instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private const string MusicVolumeKey = "MusicVolume";
    private const string SFXVolumeKey = "SFXVolume";
    private const string MusicToggleKey = "MusicToggle";
    private const string SFXToggleKey = "SFXToggle";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Theme");

        // Load saved settings
        if (PlayerPrefs.HasKey(MusicVolumeKey))
            musicSource.volume = PlayerPrefs.GetFloat(MusicVolumeKey);
        if (PlayerPrefs.HasKey(SFXVolumeKey))
            sfxSource.volume = PlayerPrefs.GetFloat(SFXVolumeKey);
        if (PlayerPrefs.HasKey(MusicToggleKey))
            musicSource.mute = PlayerPrefs.GetInt(MusicToggleKey) == 1;
        if (PlayerPrefs.HasKey(SFXToggleKey))
            sfxSource.mute = PlayerPrefs.GetInt(SFXToggleKey) == 1;
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound Not found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;

        PlayerPrefs.SetInt(MusicToggleKey, musicSource.mute ? 1 : 0);
        Debug.Log("ทำงานป่ะ");
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
        PlayerPrefs.SetInt(SFXToggleKey, sfxSource.mute ? 1 : 0);
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
        PlayerPrefs.SetFloat(MusicVolumeKey, volume);
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
        PlayerPrefs.SetFloat(SFXVolumeKey, volume);
    }
}
