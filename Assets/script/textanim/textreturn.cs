using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textreturn : MonoBehaviour
{

    private bool dropAlpha;
    public bool canlashText;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (canlashText)
        {
            FlashText();
        }
    }

    private void FlashText()
    {
        if (text.alpha > 0 && dropAlpha)
        {
            text.alpha -= Time.deltaTime;
        }
        if(text.alpha <= 0)
        {
            dropAlpha = false;
        }
        if (!dropAlpha)
        {
            text.alpha += Time.deltaTime;
        }
        if(text.alpha >= 1)
        {
            dropAlpha = true;
        }
    }
}
