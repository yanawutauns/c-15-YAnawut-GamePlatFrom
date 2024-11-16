using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField] Slider slider;


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        Debug.Log($"Health slider: {slider.value} / {slider.maxValue}");
    }

    public void UpdateHealthBar(int health)
    {
        slider.value = health;
    }

}
