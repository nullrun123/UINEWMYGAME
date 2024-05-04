using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgoundMuisc : MonoBehaviour
{
    private static BackgoundMuisc backgoundMuisc;
 

    // Update is called once per frame
    void Awake()
    {
        if(backgoundMuisc == null)
        {
            backgoundMuisc = this;
            DontDestroyOnLoad(backgoundMuisc);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
