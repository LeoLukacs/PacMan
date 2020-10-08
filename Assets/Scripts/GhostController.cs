﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    public float speed = 1.0f; //The speed that the ghost can travel at.
    private Vector2 direction = Vector2.up;// The direction the ghosts faces.
    
    //References to rigidbody2d and circle collider.
    private Rigidbody2D rb2d;
    private CircleCollider2D cc2d;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cc2d = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = direction * speed;
        if (rb2d.velocity.x == 0)
        {
            transform.position = new Vector2(Mathf.Round(transform.position.x), transform.position.y);
        }
        if (rb2d.velocity.y == 0)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Round(transform.position.y));
        }
    }
}
