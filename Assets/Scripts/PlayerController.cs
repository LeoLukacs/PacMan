using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; //change speed
    
    Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Left and Right Movement
        if(Input.GetAxis("Horizontal") < 0)
        {
            //transform.position = new Vector3(transform.position.x -1, transform.position.y);
            //rb2d.AddForce(new Vector3(-1, 0));
            rb2d.velocity = Vector2.left * speed;
            transform.up = Vector2.left;
        }
       
        if (Input.GetAxis("Horizontal") > 0)
        {
            
            rb2d.velocity = Vector2.right * speed;
            transform.up = Vector2.right;
        }

        //Up and Down movement
        if (Input.GetAxis("Vertical") < 0)
        {

            rb2d.velocity = Vector2.down * speed;
            transform.up = Vector2.down;
        }

        if (Input.GetAxis("Vertical") > 0)
        {

            rb2d.velocity = Vector2.up * speed;
            transform.up = Vector2.up;
        }
    }
}
