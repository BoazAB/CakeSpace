using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hotbarSlot : MonoBehaviour
{
    public Transform original;
    public Transform hotSlot;
    public Transform thisSlot;
    public Transform[] Items;
    public GameObject instObject;
    public int scrollPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y >= 1){
            scrollPos++;
            if(scrollPos >= 10){
                scrollPos = 1;
            }
        }
         if (Input.mouseScrollDelta.y <= -1){
            scrollPos--;
            if(scrollPos <= 0){
                scrollPos = 10;
            }
        }
        Selected();
    }
    void Selected(){
        if(thisSlot.name == "slot (" + scrollPos + ")"){
            thisSlot.GetComponent<Image>().color = Color.white;
        }
        else{
            thisSlot.GetComponent<Image>().color = Color.gray;
        }
    }
}
