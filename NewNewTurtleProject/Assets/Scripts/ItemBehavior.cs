using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    void Start()
    {
    }

    //when something collides to a pizza gameObject
    void OnCollisionEnter(Collision collision)
    {
        //if the player is colliding to the pizza
        if (collision.gameObject.name == "Turtle_Model")
        {
            //destroy the object
            Destroy(this.gameObject);
        }
    }
}