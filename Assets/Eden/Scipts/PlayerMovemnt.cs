using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{
    [SerializeField] private int jumps=2;

    public KeyCode left, right;
    public float buildUp;
    public float maxSpeed;

    public KeyCode jump;
    public float jumpForce;

    private Rigidbody2D rb2D;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //move left and right.
        if (Input.GetKey(left))
        {
            rb2D.AddForce(Vector2.left * buildUp * Time.deltaTime);
            
        }
        if (Input.GetKey(right))
        {
            rb2D.AddForce(Vector2.right * buildUp * Time.deltaTime);
        }

        if (Input.GetKeyDown(jump) && jumps >0)

        {
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumps--;
        }
        if (Grounded())
        {
            // how evere many jumps dp - 2
            jumps = 1;
        }

        rb2D.velocity = new Vector2(Mathf.Clamp(rb2D.velocity.x, -maxSpeed, maxSpeed), Mathf.Clamp(rb2D.velocity.y, -jumpForce, jumpForce));
    }
    bool Grounded()
    {
       return Physics2D.BoxCast(transform.position + Vector3.down / .7f, Vector2.one / 2, 0, Vector2.zero);
    }
}
  