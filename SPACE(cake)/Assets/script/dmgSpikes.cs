using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgSpikes : MonoBehaviour
{
    public GameObject player;
    public void OnCollisionEnter2D(Collision2D other)
    {
        var Player = player.GetComponent<Animator>();
        if(other.gameObject.tag == "player"){
            health.instance.DamagePlayer(20);
             Player.Play("TakeDamage");
        }
    }
}
