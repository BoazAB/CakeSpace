using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider slider;
    public health playerHealth;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("player").GetComponent<health>();
        slider = GetComponent<Slider>();
        slider.maxValue = playerHealth.maxHealth;
        slider.value = playerHealth.maxHealth;
    }

    public void SetHealth(int hp)
    {
        slider.value = hp;
    }
}

