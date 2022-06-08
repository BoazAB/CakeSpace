using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgSpikes : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "player"){
            health.instance.DamagePlayer(20);
        }
    }
}
