using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBoss : MonoBehaviour
{
    public Slider sliderBoss;
    public healthBoss playerHealthBoss;

    private void Start()
    {
        playerHealthBoss = GameObject.FindGameObjectWithTag("player").GetComponent<healthBoss>();
        sliderBoss = GetComponent<Slider>();
        sliderBoss.maxValue = playerHealthBoss.maxHealth;
        sliderBoss.value = playerHealthBoss.maxHealth;
    }

    public void SetHealth(int hp)
    {
        sliderBoss.value = hp;
    }
}

