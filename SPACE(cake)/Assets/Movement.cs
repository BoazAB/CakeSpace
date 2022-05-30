using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed = 15f;
<<<<<<< HEAD
    public float jumpForce = 100f;
    public bool grounded;
    
=======
    public float horizontal;

>>>>>>> cf3eab088d10865dc72d6a512e57ca53dde7a16d
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
<<<<<<< HEAD
        {
            rb2D.AddForce(new Vector2(1 * moveSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(new Vector2(-1 * moveSpeed, 0));
        }

        if (Input.GetKey(KeyCode.Space) && grounded || Input.GetKey(KeyCode.W) && grounded || Input.GetKey(KeyCode.UpArrow) && grounded){
            rb2D.AddForce(new Vector2(0, jumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D terrain)
    {
        grounded = true;
    }
    private void OnCollisionExit2D(Collision2D terrain)
    {
        grounded = false;
=======
        {
            rb2D.AddForce(new Vector2(1 * moveSpeed, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(new Vector2(-1 * moveSpeed, 0));
        }
>>>>>>> cf3eab088d10865dc72d6a512e57ca53dde7a16d
    }
}