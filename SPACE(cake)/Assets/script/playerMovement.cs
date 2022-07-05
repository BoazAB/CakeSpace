using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10;
    private Rigidbody2D player;
    [SerializeField]
    private float jumpHeight = 10;
    private bool onGround;
    public bool moving;

    void Update()
    {
        Movement();
    }
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();

    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-movementSpeed, 0) * Time.deltaTime;
            moving = true;
        }
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(movementSpeed, 0) * Time.deltaTime;
            moving = true;
        }
        if ((onGround == true) && (Input.GetKeyDown(KeyCode.W))|| (onGround == true) && (Input.GetKeyDown(KeyCode.UpArrow)) || (onGround == true) && (Input.GetKeyDown(KeyCode.Space)))
        {
            Vector2 jump = new Vector2(0, jumpHeight);
            player.velocity = new Vector2(player.velocity.x, 0);
            player.AddForce(jump, ForceMode2D.Impulse);
            onGround = false;
            moving = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }
}