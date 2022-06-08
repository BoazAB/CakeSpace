using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Character
{
<<<<<<< HEAD
    public float speed;
    public float distanceToCollider;
    public LayerMask collisionLayer;

    private float horizontalInput;

    protected override void Initializtion()
=======
    private Rigidbody2D rb2D;
    public float moveSpeed = 50f;
    public float horizontal;
    void Start()
>>>>>>> 2efc7d7ec40a33b64e4355b521bbe2bab92c5e9a
    {
        base.Initializtion();
    }

    // Update is called once per frame 
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }
        else
        {
            horizontalInput = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * speed * Time.deltaTime, rb.velocity.y);
        if (horizontalInput > 0 && character.isFacingLeft)
        {
            character.isFacingLeft = false;
            Flip();
        }
        if (horizontalInput < 0 && !character.isFacingLeft)
        {
            character.isFacingLeft = true;
            Flip();
        }
        SpeedModifier();
    }

    private void SpeedModifier()
    {
        if ((rb.velocity.x > 0 && CollisionCheck(Vector2.right, distanceToCollider, collisionLayer)) || (rb.velocity.x < 0 && CollisionCheck(Vector2.left, distanceToCollider, collisionLayer)))
        {
            rb.velocity = new Vector2(.01f, rb.velocity.y);
        }
    }
}
