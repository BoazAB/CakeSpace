using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;
    // Start is called before the first frame update
    void Update()
        
    {
        if (Input.GetButtonDown("fire1"))
        {
            Shoot();
        }
    }

    // Update is called once per frame
    void Shoot ()
    {
        Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
    }
}
