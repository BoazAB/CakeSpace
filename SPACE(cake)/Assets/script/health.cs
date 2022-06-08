using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public bool triggered;
    public GameObject enemy;
    

    public healthBar healthBar;

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
                DamagePlayer(10);
                // triggered = false;
            }
    }
    // private void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.tag == "player")
    //     {
    //         triggered = true;
    //     }
    // }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);
        if(curHealth <= 0){
            Destroy(enemy);
            Debug.Log("Recieved [Item]");
        }
    }
}
