using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkItems : MonoBehaviour
{
    public GameObject egg;
    public GameObject weed;
    public GameObject flour;
    public GameObject cake;
    public Text makeCakeMsg;
    public Text winMsg;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        makeCake();
    }
    public void makeCake(){
        if(egg.activeSelf && weed.activeSelf && flour.activeSelf){
            makeCakeMsg.enabled = true;
            cake.SetActive(true);
            Debug.Log("U made the Cake!!");
            if(Input.GetKey(KeyCode.E)){
                winMsg.enabled = true;
            }
        }
    }
}
