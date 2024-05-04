using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Animations;
public class UISlidercontrol : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI slidertext = null;
    [SerializeField] private float maxsliderAmount = 100.0f;

    public void SliderChange(float value)
    {
        float localValue = value * maxsliderAmount;
        slidertext.text = localValue.ToString("0");
    }
}