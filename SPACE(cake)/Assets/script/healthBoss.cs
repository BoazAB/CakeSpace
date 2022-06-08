using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBoss : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public bool triggered;
    public GameObject thisObjDies;
    public healthBarBoss healthBarBoss;

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
                DamagePlayer(10);
            }
    }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBarBoss.SetHealth(curHealth);
        if(curHealth <= 0){
            Destroy(thisObjDies);
            Debug.Log("Recieved [Item]");
        }
    }
}
