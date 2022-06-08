using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMech : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed = 50f;
    float lockPos;
    public GameObject rotater;
    Vector3 temp;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         
        if(Input.GetKeyDown(KeyCode.Q)){
            lockPos = 55;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, lockPos);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            lockPos = 0;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, lockPos);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            lockPos = 304;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, lockPos);
        }   
        if(Input.GetKeyDown(KeyCode.Space)){
            temp = transform.localScale;
            temp.x -= Time.deltaTime;
            transform.localScale = temp;
            rb2D.AddForce(transform.up * 15 * 10);
        }
    }
}

