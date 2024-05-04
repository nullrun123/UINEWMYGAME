using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopgame : MonoBehaviour
{

    public void OnClikbuttonSTOP()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        
    }
}
