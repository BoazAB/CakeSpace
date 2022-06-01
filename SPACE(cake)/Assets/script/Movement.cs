using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed = 50f;
    public float horizontal;

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
        {
            rb2D.AddForce(new Vector2(1 * moveSpeed, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(new Vector2(-1 * moveSpeed, 0));
        }
    }
}