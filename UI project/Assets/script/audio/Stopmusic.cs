using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopmusic : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject musicObj = GameObject.FindGameObjectWithTag("GameMusic");

        if (musicObj != null)
        {
            AudioSource audioSource = musicObj.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.Stop(); // หยุดการเล่นเสียง
            }
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
