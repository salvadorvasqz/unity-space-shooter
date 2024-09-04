using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Projectile speed
    public float speed = 10f;
    //Effect
    public GameObject obstacleExplosion;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy object after 1 seconds
        Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //Move projectile
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }

    //On collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //On collision with obstacle
        if (collision.tag == "Obstacle")
        {
            //Create effect
            GameObject effect = Instantiate(obstacleExplosion, collision.transform.position, collision.transform.rotation);
            //Destroy effect
            Destroy(effect, 1f);
            //Destroy obstacle
            Destroy(collision.gameObject);
        }
    }
}
