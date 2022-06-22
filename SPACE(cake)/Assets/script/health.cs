using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int curHealth = 100;
    public int maxHealth = 100;
    public bool triggered;
    public GameObject thisObjDies;
    public healthBar healthBar;
    public static health instance;

    private void Awake(){
        instance = this;
    }
    void Start()
    {
        curHealth = maxHealth;
    }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);
        if(curHealth <= 0){
            Destroy(thisObjDies);
            Debug.Log("You died");
        }
    }
}
