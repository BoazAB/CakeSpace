using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("egg")){
           SceneManager.LoadScene("planetEgg");
        }
        if(other.CompareTag("weed")){
           SceneManager.LoadScene("planetWeed");
        }
        if(other.CompareTag("flour")){
           SceneManager.LoadScene("planetFlour");
        }
    }
}
