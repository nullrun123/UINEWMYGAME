using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopgame : MonoBehaviour
{
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.V)){

            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
    public void OnClikbuttonSTOP()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        
    }
}
