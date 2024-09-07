using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Effect
    public GameObject playerExplosion;
    //Obstacle scale limits
    public float scaleMax = 1.3f;
    public float scaleMin = 0.7f;
    //Obstacle rotation limits
    public float rotationMax = 180f;
    public float rotationMin = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Set random size
        randomSize();
        //Set random rotation
        randomRotation();
    }

    //On collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //On collision with player
        if (collision.tag == "Player")
        {
            //Create effect
            GameObject effect = Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
            //Destroy effect
            Destroy(effect, 1f);
            //Destroy player
            Destroy(collision.gameObject);
        }
    }

    //Set random size
    void randomSize()
    {
        //Get new scale factor
        float scaleFactor = Random.Range(scaleMin, scaleMax);
        //Set new scale
        transform.localScale = (Vector2)transform.localScale * scaleFactor;
    }

    //Set random rotation
    void randomRotation()
    {
        //Get new rotation factor
        float rotationFactor = Random.Range(rotationMin, rotationMax);
        //Set new ration angle
        transform.localEulerAngles = Vector3.forward * rotationFactor;
    }
}
