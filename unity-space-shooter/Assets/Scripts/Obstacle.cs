using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //On collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //On collision with player
        if (collision.tag == "Player")
        {
            //Destroy player
            Destroy(collision.gameObject);
        }
    }
}
