using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManagerSFX : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted1 = false;
    // Start is called before the first frame update


    void Start()
    {
        if (!PlayerPrefs.HasKey("muted1"))
        {
            PlayerPrefs.SetInt("muted1", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();

    }
    public void onButtonPress()
    {
        if (muted1 == false)
        {
            muted1 = true;

        }
        else
        {
            muted1 = false;

        }

        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (muted1 == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;

        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }



    }
    private void Load()
    {
        muted1 = PlayerPrefs.GetInt("muted1") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted1", muted1 ? 1 : 0);
    }
}
