using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider playerHP;
    public health playerHealth;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("player").GetComponent<health>();
        playerHP = GetComponent<Slider>();
        playerHP.maxValue = playerHealth.maxHealth;
        playerHP.value = playerHealth.maxHealth;
    }

    public void SetHealth(int hp)
    {
        playerHP.value = hp;
    }
}

