using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxAmount(int amount)
    {
        slider.maxValue = amount;
        slider.value = amount;
    }

    public void SetAmount(int amount)
    {
        slider.value = amount;
    }
}
