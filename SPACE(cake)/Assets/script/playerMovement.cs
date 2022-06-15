using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [HideInInspector]
    public float speed = 100f;
    private float horizontalInput;


    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput != 0)
        {
            rb.AddForce(new Vector2(horizontalInput * speed, 0f));
        }
        if (horizontalInput < 0)
        {
            gameObject.transform.localScale = new Vector2(1, 1);
        }
        if (horizontalInput > 0)
        {
            gameObject.transform.localScale = new Vector2(-1, 1);
        }
    }
}
