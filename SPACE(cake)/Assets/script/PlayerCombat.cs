using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float AttackRange = 0.5f;
    public int AttackDmg = 50;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        Collider2D[] hitEnemy = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);
        
        foreach(Collider2D Enemy in hitEnemy)
        {
            Enemy.GetComponent<health>().DamagePlayer(AttackDmg);
        }
    }
}
