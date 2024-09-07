using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Effect
    public GameObject pickupEffect;

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
            //Create effect
            GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);
            //Destroy effect
            Destroy(effect, 0.3f);
            //Destroy item
            Destroy(this.gameObject);
        }
    }
}
