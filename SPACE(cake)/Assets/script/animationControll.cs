using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControll : MonoBehaviour
{
    public GameObject player;
    public Animator animate;
    bool isPlaying;
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetKeyDown("w") ){
            animate.Play("Jumping");
        }
        if (Input.GetKeyDown("f")){
            animate.Play("Attack");
        }
        if (Input.GetKeyDown("d") || Input.GetKeyDown("a")){
            isPlaying = true;
        }
         if (Input.GetKeyUp("d") || Input.GetKeyUp("a")){
            isPlaying = false;
        }
        if (isPlaying == true){
            animate.Play("Walk_Cycle");
        }
        if (Input.GetKeyDown("e")){
            animate.Play("Pick_Up");
        }
    }
}