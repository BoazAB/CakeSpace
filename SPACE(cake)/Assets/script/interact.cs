using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class interact : MonoBehaviour
{
    [SerializeField] private Text customText;
    bool key;
    bool x;
    void Update(){
        if(x = true && Input.GetKey(KeyCode.E)){
            Debug.Log("Player interacted with the button");
        }
        else {
            x = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("player")){
            Debug.Log("coll");
            customText.enabled = true;
            x = true;
        }
        
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("player")){
            Debug.Log("not coll");
            customText.enabled = false;
            x = false;
        }
    }
}
