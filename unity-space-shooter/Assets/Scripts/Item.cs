using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //On collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //On collision with player
        if (collision.tag == "Player")
        {
            //Get player
            Player player = collision.GetComponent<Player>();
            //Add points
            player.points++;
            //Destroy item
            Destroy(this.gameObject);
        }
    }
}
