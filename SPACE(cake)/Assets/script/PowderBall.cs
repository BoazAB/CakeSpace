using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowderBall : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Hit(int damage)
    {
        currentHealth -= damage;
        
        if(currentHealth <= 0)
        {
            Launch();
        }
    }

    public void Launch()
    {
        Debug.Log("cheese");
    }
}
