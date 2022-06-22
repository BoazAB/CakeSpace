using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBoss : MonoBehaviour
{
    public GameObject item;
    public int curHealth = 0;
    public int maxHealth = 100;
    public bool triggered;
    public GameObject egg;
    public GameObject weed;
    public GameObject flour;

    public GameObject thisObjDies;
    public healthBarBoss hpBarBoss;
    void Start()
    {
        curHealth = maxHealth;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
                DamagePlayer(10);
            }
    }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        hpBarBoss.SetHealth(curHealth);
        if(curHealth <= 0){
            Destroy(thisObjDies);
            if(thisObjDies.tag == "eggBoss"){
                egg.SetActive(true);
                Debug.Log("Recieved [Egg]");
            }
            if(thisObjDies.tag == "weedBoss"){
                weed.SetActive(true);
                Debug.Log("Recieved [Weed]");
            }
            if(thisObjDies.tag == "flourBoss"){
                flour.SetActive(true);
                Debug.Log("Recieved [Flour]");
            }
            else{
                Debug.Log("no tag has been found on bos");
            }
        }
    }
}
