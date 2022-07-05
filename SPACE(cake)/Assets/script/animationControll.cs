using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControll : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Start(){
       
    }
    void Update()
    {
        var Player = player.GetComponent<Animator>();
        if (Input.GetKeyDown("space") || Input.GetKeyDown("w") ){
            Player.Play("Jumping");
        }
        if (Input.GetKeyDown("f")){
            Player.Play("Attack");
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("a")){
            Player.Play("Walk_Cycle");
        }
        if (Input.GetKeyDown("e")){
            Player.Play("Pick_Up");
        }
    }
}
