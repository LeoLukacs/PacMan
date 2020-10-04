using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 100; //The amounth of points to give the player. (this is much
    //better than hard coding values.

    void Start() //object stars up
    {
        
    }

    
    void Update() //happens every frame
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            coll.gameObject.GetComponent<PlayerController>().addPoints(points);
            Destroy(this.gameObject); //deletes script and the gameobject. 
            
        }
    }
}
