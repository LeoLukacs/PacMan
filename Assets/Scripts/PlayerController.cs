using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; //change speed
    private Vector2 direction;// the direction PacMan is going.
    
    Rigidbody2D rb2d;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.SetBool("isMoving?", rb2d.velocity.magnitude > 0);

        //Left and Right Movement
        if(Input.GetAxis("Horizontal") < 0)
        {
            //transform.position = new Vector3(transform.position.x -1, transform.position.y);
            //rb2d.AddForce(new Vector3(-1, 0));
            direction = Vector2.left;
        }
       
        if (Input.GetAxis("Horizontal") > 0)
        {

            direction = Vector2.right;
        }

        //Up and Down movement
        if (Input.GetAxis("Vertical") < 0)
        {

            direction = Vector2.down;
        }

        if (Input.GetAxis("Vertical") > 0)
        {

            direction = Vector2.up;
        }
       
        rb2d.velocity = direction * speed;
        transform.up = direction;
        
        //cant change values, so x stays the same when y is changing.
        if(rb2d.velocity.x == 0)
        {
            transform.position = new Vector2(Mathf.Round(transform.position.x), transform.position.y);
        }
        if (rb2d.velocity.y == 0)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Round(transform.position.y));
        }
    }
}
